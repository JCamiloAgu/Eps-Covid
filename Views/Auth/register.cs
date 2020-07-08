using CitasEps.Controllers;
using CitasEps.Models;
using CitasEps.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CitasEps.Views.AuthUser {
	public partial class register : Form {
		private List<Media> mediaItemsGet = new List<Media>();
		private readonly AffiliatesController affiliatesController;
		private readonly UsersController usersController;
		private readonly MediaController mediaController;
		private readonly EmailConfirCodeController emailConfirCodeController;
		private readonly UsersMediaController usersMediaController;
		private readonly int id = -1;
		private string identification;
		private string phone;
		private string address;
		private string email;
		private string password;
		private string confirm;


		public register() {
			InitializeComponent();
			affiliatesController = new AffiliatesController();
			usersController = new UsersController();
			mediaController = new MediaController();
			emailConfirCodeController = new EmailConfirCodeController();
			usersMediaController = new UsersMediaController();
		}

		private void register_Load(object sender, EventArgs e) {

			// Cargar lista de media
			mediaItemsGet = mediaController.GetAll();
			foreach (var item in mediaItemsGet) {
				if (item.GetAttribute("id").ToString() != "0") {
				checkedList.Items.Add(item.GetAttribute("name").ToString());
				}
			}
		}

		// Metodo que valida los inputs del registro
		private bool InputValidator() {
			bool state = true;
			identification = txtIdentification.Text;
			phone = txtPhone.Text;
			address = txtAddress.Text;
			email = txtEmail.Text;
			password = txtPassword.Text;
			confirm = txtConfirm.Text;

			if(confirm != password){
				MessageBox.Show("El password no coincide con la confirmación!", "Error");
				state = false;
			}

			if (checkedList.CheckedItems.Count == 0) {
				MessageBox.Show("Selecciona algun medio!", "Error");
				state = false;
			}
			return state;
		}

		private void btnRegister_Click(object sender, EventArgs e) {
			if (InputValidator()) {
				//1) Consultar existencia del afiliado				
				Models.Affiliate affiliate = affiliatesController.Get("identification", identification);
				if (affiliate == null) MessageBox.Show("No existe el afiliado en la eps.");
				else {


					//2) Terminar de armar el objeto User para crearlo en base de datos
					int id_affiliates = int.Parse(affiliate.GetAttribute("id").ToString());
					Models.User user = new Models.User(id, id_affiliates, phone, address, email, password);
					int newIdUser = usersController.Create(user);


					//3) Generar codigo de confirmacion del email
					string code = HelpersService.GetCode();
					Email_Confirm_Code emailConfirmCode = new Email_Confirm_Code(id, newIdUser, code, false);
					int newIdEmailConfirmCode = emailConfirCodeController.Create(emailConfirmCode);
					if (newIdEmailConfirmCode != -1) {

						// Proceso asincrono para enviar email
						Task.Run(async () => {
							await EmailService.SendEmailAsync(email.ToString(), code);
						});
					}

					//4) Generar relacion entre media y usuario
					foreach (string itemName in checkedList.CheckedItems) {
						int indexMedia = 0;
						int indexSelect = -1;

						// Busca en la lista que trae de base de datos cada item seleccionado
						foreach (Media itemMedia in mediaItemsGet) {
							if (itemMedia.GetAttribute("name").ToString() == itemName) {
								indexSelect = indexMedia;
							}
							indexMedia++;
						}
						if (indexSelect != -1) {

							// Crea en base de datos un registro de Users_Media en cada iteracion
							int idMediaSelect = int.Parse(mediaItemsGet[indexSelect].GetAttribute("id").ToString());
							User_Media userMedia = new User_Media(newIdUser, idMediaSelect);
							usersMediaController.Create(userMedia);
						}
					}
					MessageBox.Show("¡Usuario creado con exito!", "Mensaje");
					MessageBox.Show("¡Vaya a su correo para confirmar el registro!", "Mensaje");
					confirm_email frmConfirmEmail = new confirm_email();
					frmConfirmEmail.emailUser = email; // enviar  informacion a otro formulario
					frmConfirmEmail.typeFormReturn = "login";
					frmConfirmEmail.Show();
					Close();
				}
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			login frm = new login();
			frm.Show();
			Close();
		}
	}
}

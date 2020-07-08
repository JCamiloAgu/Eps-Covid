using System;

namespace CitasEps.Services {
	class HelpersService {
		
		public static string DateFormatToString(DateTime dateTime) {
			return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
		}

		// Codigo random unico de 8 digitos
		public static string GetCode() {
			byte[] buffer = Guid.NewGuid().ToByteArray();
			var FormNumber = BitConverter.ToUInt32(buffer, 0) ^ BitConverter.ToUInt32(buffer, 4) ^ BitConverter.ToUInt32(buffer, 8) ^ BitConverter.ToUInt32(buffer, 12);
			return FormNumber.ToString("X");

		}
	}
}

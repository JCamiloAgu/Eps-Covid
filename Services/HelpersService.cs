using System;

namespace CitasEps.Services
{
    class HelpersService
    {
        public static string DateFormatToString(DateTime dateTime) => dateTime.ToString("yyyy-MM-dd HH:mm:ss");


        public static string GetRandomCode()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            var FormNumber = BitConverter.ToUInt32(buffer, 0) ^ BitConverter.ToUInt32(buffer, 4) ^ BitConverter.ToUInt32(buffer, 8) ^ BitConverter.ToUInt32(buffer, 12);
            return FormNumber.ToString("X");
        }
    }
}

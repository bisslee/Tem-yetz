using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace YetzFlow.Core
{
    public static class Helper
    {
        #region Cleanners
        public static string CleanCPF(this string cpf)
        {
            return cpf.Replace("-", "").Replace(".", ""); ;
        }
        public static string CleanCNPJ(this string cnpj)
        {
            return cnpj.Replace("-", "").Replace(".", "").Replace("/", "");
        }
        #endregion Cleanners

        #region Validators
        public static bool IsCPFValid(this string cpf)
        {
            if (cpf.Length != 11)
            {
                return false;
            }

            switch (cpf)
            {
                case "00000000000":
                case "11111111111":
                case "22222222222":
                case "33333333333":
                case "44444444444":
                case "55555555555":
                case "66666666666":
                case "77777777777":
                case "88888888888":
                case "99999999999":
                    return false;
                default:
                    break;
            }

            int] multiplicador1 = new int9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int] multiplicador2 = new int10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;

            string digito;

            int soma;

            int resto;

            cpf = cpf.Trim();

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)

                return false;

            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)

                soma += int.Parse(tempCpfi].ToString()) * multiplicador1i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += int.Parse(tempCpfi].ToString()) * multiplicador2i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

        }
        public static bool IsCNPJValid(this string cnpj)
        {
            if (cnpj.Length!= 14)
            {
                return false;
            }

            switch (cnpj)
            {
                case "00000000000000":
                case "11111111111111":
                case "22222222222222":
                case "33333333333333":
                case "44444444444444":
                case "55555555555555":
                case "66666666666666":
                case "77777777777777":
                case "88888888888888":
                case "99999999999999":
                    return false;
                default:
                    break;
            }

            int] multiplicador1 = new int12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int] multiplicador2 = new int13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpji].ToString()) * multiplicador1i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpji].ToString()) * multiplicador2i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        public static bool IsEmailValid(this string email)
        {
            Regex rg = new Regex(@"^A-Za-z0-9]((_\.\-]?a-zA-Z0-9]+)*)@(A-Za-z0-9]+)((\.\-]?a-zA-Z0-9]+)*)\.(A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion Validators

        #region CryptoTools
        public static string ComputeSha256Hash(this string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytesi].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        #endregion CryptoTools
    }
}

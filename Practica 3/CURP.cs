using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class CURP : Form
    {
        public CURP()
        {
            InitializeComponent();
        }

        public string Estado(string estado)
        {
            switch (estado)
            {
                case "AG": return "Aguascalientes"; break;
                case "BC": return "Baja California"; break;
                case "BS": return "Baja California Sur"; break;
                case "CC": return "Campeche"; break;
                case "CS": return "Chiapas"; break;
                case "CH": return "Chihuahua"; break;
                case "CL": return "Coahuila"; break;
                case "DG": return "Durango"; break;
                case "GT": return "Guanajuato"; break;
                case "GR": return "Guerrero"; break;
                case "HG": return "Hidalgo"; break;
                case "JC": return "Jalisco"; break;
                case "MC": return "México"; break;
                case "MN": return "Michoacán"; break;
                case "MS": return "Morelos"; break;
                case "NT": return "Nayarit"; break;
                case "NL": return "Nuevo León"; break;
                case "OC": return "Oaxaca"; break;
                case "PL": return "Puebla"; break;
                case "QT": return "Querétaro"; break;
                case "QR": return "Quintana Roo"; break;
                case "SP": return "San Luis Potosí"; break;
                case "SL": return "Sinaloa"; break;
                case "SR": return "Sonora"; break;
                case "TC": return "Tabasco"; break;
                case "TS": return "Tamaulipas"; break;
                case "TL": return "Tlaxcala"; break;
                case "VZ": return "Veracruz"; break;
                case "YN": return "Yucatán"; break;
                case "ZS": return "Zacatecas"; break;
                default: return "Abreviatura no reconocida"; break;
            }
        }

        public string Sexo(string sexo)
        {
            if (sexo == "H")
            {
                return "Masculino";
            }
            else
            {
                return "Femenino";
            }
        }

        private void CURP_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string curp = TbCurp.Text;
            string expresion = "^[A-Z]{4}\\d{6}[HM]{1}[A-Z]{2}[A-Z]{3}[0-9A-Z]{2}$";
          

            if (Regex.IsMatch(curp, expresion) == true)
            {
                string year = curp[4].ToString() + curp[5].ToString();
                string mes = curp[6].ToString() + curp[7].ToString();
                string dia = curp[8].ToString() + curp[9].ToString();

                string sexo = curp[10].ToString();
                string estado = curp[11].ToString() + curp[12].ToString();
                DateTime fecha = DateTime.Parse(dia + "/" + mes + "/" + year);

                MessageBox.Show("Tu fecha de Nacimiento es: " + fecha.ToString("dd/MM/yyyy") + "\nEl Tu sexo es: " + Sexo(sexo) + "\nEl Tu estado es: " + Estado(estado));
            }
            else
            {
                MessageBox.Show("TU CURP ES INVALIDA, ESCRIBELA CORRECTAMENTE");
            }
        }

    }
}
 

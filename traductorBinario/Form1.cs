using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traductorBinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //BUSCA EL ARCHIVO QUE SE LEERÁ PARA COLOCAR EN LA CAJA DE TEXTO
        private void findArch_Click(object sender, EventArgs e)
        {
            using (var arch = new OpenFileDialog())
            {
                if (arch.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(arch.SafeFileName))
                {
                    MessageBox.Show(arch.FileName, "Se abrió correctamente el archivo:");
                    string archivo = arch.FileName;
                    leerArchivo(archivo);
                }
                else
                {
                    MessageBox.Show("No se abrió ningún archivo.", "ERROR");
                }
            }
        }

        //ABRE EL ARCHIVO
        private void leerArchivo(string ubicacionArchivo)
        {
            System.IO.StreamReader archivo = new System.IO.StreamReader(ubicacionArchivo);
            textBox1.Text = copiarTexto(archivo);
        }

        //LEE EL ARCHIVO Y LO COLOCA EN LA CAJA DE TEXTO
        private string copiarTexto(System.IO.StreamReader archivo)
        {
            string texto = null;
            string linea;
            int centinela = 1;

            while((linea = archivo.ReadLine()) != null)
            {
                if(centinela == 1)
                {
                    texto += linea;
                    centinela = 0;
                }
                else
                {
                    texto += (" " + linea);
                }
            }

            return texto;
        }

        //INICIA LA TRADUCCIÓN DE BINARIO A CARACTERES
        private void traducirLetras_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text, traduccion = null;
            string[] bytes;
            char[] numeroBinario;
            int exponente, cifra, caracterInt;
            bool centinela = true, esByte = true;

            bytes = text.Split(' ');

            for(int i=0; i < bytes.Length; i++)
            {
                numeroBinario = bytes[i].ToCharArray();

                //REVISA SI LA INFORMACIÓN ES EN BYTES
                if(numeroBinario.Length != 8)
                {
                    MessageBox.Show("La información debe ser introducida en bytes.", "ERROR");
                    centinela = false;
                    break;
                }

                exponente = 7;
                caracterInt = 0;

                //ASCII DEL 0 ES 48 Y DEL 1 ES 49
                for(int j=0; j < numeroBinario.Length; j++)
                {
                    cifra = ((int)numeroBinario[j] - 48) * (int)Math.Pow(2, exponente);
                    caracterInt += cifra;
                    exponente--;

                    if (numeroBinario[j] != '1' && numeroBinario[j] != '0')
                    {
                        MessageBox.Show("La información debe ser introducida en bytes.", "ERROR");
                        centinela = false;
                        esByte = false;
                        break;
                    }
                }

                if(!esByte)
                {
                    break;
                }

                traduccion += string.Join("", (char)caracterInt);
            }

            if (centinela && esByte)
            {
                MessageBox.Show(traduccion, "Texto traducido a caracteres");

                DialogResult resp = MessageBox.Show("Desea copiar el texto al portapapeles?", "Texto traducido a caracteres", MessageBoxButtons.YesNo);

                if (resp == DialogResult.Yes)
                {
                    System.Windows.Forms.Clipboard.SetDataObject(traduccion, true);
                }
            }
        }

        //INICIA LA TRADUCCIÓN DE CARACTER A BINARIO
        private void traducirBinario_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text, traduccion = null;
            char[] arregloCaracteres = texto.ToCharArray();
            char car;
            int i = 0, valorCar;

            while(i < arregloCaracteres.Length)
            {
                car = arregloCaracteres[i];
                valorCar = (int)car;

                if(i == 0)
                {
                    traduccion += intEnBinario(valorCar);
                }
                else
                    traduccion += (" " + intEnBinario(valorCar));

                i++;
            }

            MessageBox.Show(traduccion, "Texto traducido a binario");

            DialogResult resp = MessageBox.Show("Desea copiar el texto al portapapeles?", "Texto traducido a binario", MessageBoxButtons.YesNo);

            if(resp == DialogResult.Yes)
            {
                System.Windows.Forms.Clipboard.SetDataObject(traduccion, true);
            }
        }

        //CONVERSIÓN DE UN ENTERO A BINARIO EN BYTES
        private string intEnBinario(int valorCar)
        {
            string binario = null;
            int digito, numBinario=0, exponente = 0;

            while(valorCar > 0)
            {
                digito = valorCar % 2;
                valorCar /= 2;
                numBinario += (digito * (int)Math.Pow(10, exponente));
                exponente++;
            }

            //Usamos el exponente como la cantidad de digitos para poder rellenar el byte

            int cantCeros = 8 - exponente;

            for(int i=0; i < cantCeros; i++)
            {
                binario += "0";
            }

            binario += numBinario.ToString();

            return binario;
        }
    }
}

/*          //CADENA A STRING
            char[] su;

            su = new char[2];

            su[0] = 'h';
            su[1] = 'i';

            string hi = string.Join(" ", su);

            //STRING A CADENA DE CARACTERES

            string prueba = "hola";
            char[] arr;

            arr = prueba.ToCharArray();

            string texto = arr[3].ToString();

            //STRING A CADENA DE STRINGS

            string prueba2 = "hola que tal";
            string[] array;

            array = prueba2.Split(' ');

            //INT A CARACTER

            int numero = 65;

            string prueba3 = ((char)numero).ToString();

            MessageBox.Show(texto);*/
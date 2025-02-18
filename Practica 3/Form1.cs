//Angel Daniel Salinas Ortiz
//No Control: 23130598  Data Grid View
namespace Practica_3
{
    public partial class Form1 : Form
    {
        string filePath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void botonCargar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                try
                {
                    string documento = File.ReadAllText(filePath);

                    string[] fila = documento.Split('\n');
                    string[] col = fila[0].Split(',');


                    dataGridView1.ColumnCount = col.Length;
                    dataGridView1.RowCount = fila.Length;
                    for (int i = 0; i < col.Length; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = col[i];
                    }
                    for (int i = 1; i < (fila.Length) - 1; i++)
                    {
                        col = fila[i].Split(',');
                        for (int j = 0; j < col.Length; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = col[j];
                        }
                    }
                    MessageBox.Show(fila.Length - 1 + " registros cargados.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
        }
    }
}
 
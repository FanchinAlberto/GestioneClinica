using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneClinica
{
    public partial class Form1 : Form
    {
        
        List<Paziente> pazienti = new List<Paziente>();
        List<Medico> medici = new List<Medico>();
        List<DateTime> date = new List<DateTime>();
        string[] patologie = new string[19];
        string[] specializzazioni = new string[23];
        bool dataFilter = false;
        bool patientFilter = false; 
        bool doctorFilter = false;  
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private DataTable InputDataPazienti()
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader("pazienti.csv"))
            {
                string[] headers = sr.ReadLine().Split(';');
                    dt.Columns.Add(headers[0]);
                    dt.Columns.Add(headers[1]);
                    dt.Columns.Add(headers[5]);
                    dt.Columns.Add(headers[6]);

                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(';');
                    DataRow dr = dt.NewRow();
                    dr[0] = rows[0];
                    dr[1] = rows[1];
                    dr[2] = patologie[Convert.ToInt32(rows[5])-1];
                    dr[3] = rows[6];
                    Paziente p1 = new Paziente(rows[0], rows[1], rows[5], rows[6]);
                    pazienti.Add(p1);
                    dt.Rows.Add(dr);
                }

            }


            return dt;
        }

        private DataTable InputDataMedici()
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader("medici.csv"))
            {
                string[] headers = sr.ReadLine().Split(';');
                dt.Columns.Add(headers[0]);
                dt.Columns.Add(headers[1]);
                dt.Columns.Add(headers[3]);
                dt.Columns.Add(headers[4]);

                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(';');
                    DataRow dr = dt.NewRow();
                    dr[0] = rows[0];
                    dr[1] = rows[1];
                    dr[2] = rows[3];
                    dr[3] = specializzazioni[Convert.ToInt32(rows[4])-1];
                    Medico m1 = new Medico(rows[0], rows[1], rows[3], dr[3].ToString());
                    medici.Add(m1);
                    dt.Rows.Add(dr);
                }

            }


            return dt;
        }

        private DataTable InputPatologie()
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader("patologie.csv"))
            {
                string[] headers = sr.ReadLine().Split(';');
                dt.Columns.Add(headers[0]);
                dt.Columns.Add(headers[1]);
                int cont = 0;

                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(';');
                    DataRow dr = dt.NewRow();
                    
                    for (int i = 0; i< rows.Length; i++)
                    {
                        dr[i] = rows[i];
                        patologie[cont] = dr[1].ToString();
                    }
                    cont++;
                    dt.Rows.Add(dr);
                }
                

            }


            return dt;
        }


        private DataTable InputSpecializzazioni()
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader("specializzazioni.csv"))
            {
                string[] headers = sr.ReadLine().Split(';');
                dt.Columns.Add(headers[0]);
                dt.Columns.Add(headers[1]);
                dt.Columns.Add("");
                int cont = 0;

                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(';');
                    DataRow dr = dt.NewRow();
                    

                    for (int i = 0; i < rows.Length; i++)
                    {
                        dr[i] = rows[i];
                        specializzazioni[cont] = dr[1].ToString();
                    }
                    cont++;
                    dt.Rows.Add(dr);
                }

                dt.Columns.RemoveAt(2);
            }


            return dt;
        }

        private DataTable InputAppuntamenti()
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader("appuntamenti.csv"))
            {
                string[] headers = sr.ReadLine().Split(';');
                dt.Columns.Add(headers[0]);
                dt.Columns.Add(headers[1]);
                dt.Columns.Add(headers[2]);
                dt.Columns[0].DataType = System.Type.GetType("System.DateTime");
                

                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(';');
                    DataRow dr = dt.NewRow();

                    dr[0] = rows[0];
                    date.Add((DateTime)dr[0]);
                    dr[1] = pazienti[Convert.ToInt32(rows[1])-1].GetName();
                    dr[2] = medici[Convert.ToInt32(rows[2])-501].GetName();

                    dt.Rows.Add(dr);
                }
                
                
            }


            return dt;
        }

        private DataTable FiltraAppuntamenti()
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader("appuntamenti.csv"))
            {
                string[] headers = sr.ReadLine().Split(';');
                dt.Columns.Add(headers[0]);
                dt.Columns.Add(headers[1]);
                dt.Columns.Add(headers[2]);
                dt.Columns[0].DataType = System.Type.GetType("System.DateTime");


                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(';');
                    DataRow dr = dt.NewRow();

                    dr[0] = rows[0];
                    date.Add((DateTime)dr[0]);
                    dr[1] = pazienti[Convert.ToInt32(rows[1]) - 1].GetName();
                    dr[2] = medici[Convert.ToInt32(rows[2]) - 501].GetName();

                    dt.Rows.Add(dr);
                }


            }


            return dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridViewPatologie.DataSource = InputPatologie();
            gridViewSpecializzazioni.DataSource = InputSpecializzazioni();
            gridViewPazienti.DataSource = InputDataPazienti();
            gridViewMedici.DataSource = InputDataMedici();
            gridViewAppuntamenti.DataSource = InputAppuntamenti();
            cmbPazienti.DataSource = pazienti;
            cmbPazienti.DisplayMember = "Nomecognome";
            cmbMedici.DataSource = medici;
            cmbMedici.DisplayMember = "Nomecognome";

        }

        private void cbxDataFilter_CheckedChanged(object sender, EventArgs e)
        {
            dataFilter = true;
        }

        private void cbxPazienteFilter_CheckedChanged(object sender, EventArgs e)
        {
            patientFilter = true;
        }

        private void cbxMedicoFilter_CheckedChanged(object sender, EventArgs e)
        {
            doctorFilter = true;
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            gridViewAppuntamenti.DataSource = null;
            gridViewAppuntamenti.DataSource = FiltraAppuntamenti();
        }
    }
}

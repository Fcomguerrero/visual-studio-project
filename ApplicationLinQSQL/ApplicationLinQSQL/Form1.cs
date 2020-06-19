using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ApplicationLinQSQL
{
    public partial class Form1 : Form
    {
        //Data for the connection to the database
        private  Conexion conecc = new Conexion(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DataBase;Data Source=CORE-I5");
        
        public Form1()
        {
            InitializeComponent();
        }

       //DataClasses1DataContext dbo = new DataClasses1DataContext();       

        private void Form1_Load(object sender, EventArgs e)
        {            
            listar(); 
        }
        //*******************************************************************************************
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)  //if click column 0
            {                
                text_Titulo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                text_Pista.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                text_Interprete.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                text_Album.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();       
                text_Genero.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();                
                text_Ano.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                text_Num.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                label6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();  //save primary Key
                                
            }
        }
        //*******************************************************************************************
        private void B_Insert_data_Click(object sender, EventArgs e)
        {          
            //busca si existe la combinacion de Primary key en la tabla Musica                
            string sql = string.Format("SELECT * FROM Musica WHERE Numero='" + text_Num.Text + "'");
            Boolean resul = conecc.ConsultaResul(sql);
            
            if (!resul)  //if no exist a file with the same Primary Key
            {
                Boolean todoBien = true;
                if (text_Titulo.Text == "" || text_Pista.Text == "" || text_Interprete.Text == "" || 
                    text_Album.Text == "" || text_Genero.Text == "" || text_Ano.Text == "" || text_Num.Text == "")
                {                     
                    MessageBox.Show("Ningun Campo puede quedar en Blanco");
                    todoBien = false;
                }
                if (todoBien)
                {
                    string insert = "INSERT INTO Musica(Titulo,Pista,Interprete,Album,Genero,Ano,Numero)VALUES('"
                        + text_Titulo.Text + "','"
                        + Convert.ToInt32(text_Pista.Text) + "','"
                        + text_Interprete.Text + "','"
                        + text_Album.Text + "','"
                        + text_Genero.Text + "','"
                        + Convert.ToInt32(text_Ano.Text) + "','"
                        + text_Num.Text + "')";

                    SqlCommand cmd = new SqlCommand(insert, conecc.sqlConn);
                    conecc.sqlConn.Open();
                    cmd.ExecuteNonQuery();
                    conecc.sqlConn.Close();

                    MessageBox.Show("Added Successful");
                    clean();
                    listar();
                }
            }
            else
            {
                //if Primary Key Exist in DataBase
                MessageBox.Show("Ya existe en la base de datos el Num " + text_Num.Text); 
                text_Num.Text = "";
            }
        }
        //********************************************************************************************
        private void B_Update_Click(object sender, EventArgs e)
        {                      
            //busca si existe la combinacion de Primary key en la tabla Musica                
            string sql = string.Format("SELECT * FROM Musica WHERE Numero='" + text_Num.Text +"'");
            Boolean resul = conecc.ConsultaResul(sql);
            
            if (resul) //si existe hago esto
            {               
               string UpD = "UPDATE Musica SET " +
                    "Titulo='" + text_Titulo.Text +"'"+","+
                    "Pista='" + Convert.ToInt32(text_Pista.Text) + "'" + "," +
                    "Interprete='" + text_Interprete.Text + "'" + "," +
                    "Album='" + text_Album.Text + "'" + "," +
                    "Genero='" + text_Genero.Text + "'" + "," +
                    "Ano='" + Convert.ToInt32(text_Ano.Text)+"'"+
                    "where Numero='" + text_Num.Text +"'";

                SqlCommand cmd = new SqlCommand(UpD, conecc.sqlConn);
                conecc.sqlConn.Open();
                cmd.ExecuteNonQuery();
                conecc.sqlConn.Close();

                MessageBox.Show("Update Successful");
                clean();
            }
            listar();            
        }
        //********************************************************************************************
        private void B_Buscar_Click(object sender, EventArgs e)
        {
            if (text_Titulo.Text == "") {
                MessageBox.Show("Debe ingresar el Titulo a buscar");
            }            
            string sql = string.Format("SELECT * FROM Musica WHERE Titulo LIKE '%"+text_Titulo.Text.ToLower()+"%'");            
            Boolean resul = conecc.ConsultaResul(sql);
                          
            if (resul) //if found
            {                
                conecc.abrir();
                SqlDataAdapter daList = new SqlDataAdapter(sql, conecc.sqlConn); //Selec all from table Musica
                DataSet dsList = new DataSet();
                daList.Fill(dsList, "Musica"); //Fill the list with the table

                //Show dsLint on dataGridView1
                dataGridView1.DataSource = dsList;
                dataGridView1.DataMember = "Musica";
                conecc.Cerrar();                                                
            }
            else
            {
                //If the file was not found in the database
                MessageBox.Show("No se han encontrado coincidencias con el Titulo "+ text_Titulo.Text +" ");
            }

        }
        //*********************************************************************************************
        private void B_Delete_Click(object sender, EventArgs e)
        {
            //Buscar si existe la primary key
            string sql = string.Format("SELECT * FROM Musica WHERE Numero='" + text_Num.Text + "'");
            Boolean resul = conecc.ConsultaResul(sql);
           
            if (resul) //si existe en la base de datos 
            {
                string UpD = "DELETE Musica where Numero='" + text_Num.Text + "'";

                SqlCommand cmd = new SqlCommand(UpD, conecc.sqlConn);
                conecc.sqlConn.Open();
                cmd.ExecuteNonQuery();
                conecc.sqlConn.Close();
                MessageBox.Show("Deleted Successful");
            }
            else
            {
                //If the file was not found in the database
                MessageBox.Show("Num " + text_Num.Text + " no existe en la base de datos");                
            }            
            clean();
            listar();
        }
        //*********************************************************************************************
        void clean()
        {
            //Clean all TextBox
            text_Titulo.Text = "";
            text_Pista.Text = "";
            text_Interprete.Text = "";
            text_Album.Text = "";
            text_Genero.Text = "";
            text_Ano.Text = "";
            text_Num.Text = "";
        }
        //**********************************************************************************************
        private void listar()
        {            
            conecc.abrir();
            SqlDataAdapter daList = new SqlDataAdapter("Select * from Musica", conecc.sqlConn); //Selec all from table Musica
            DataSet dsList = new DataSet();
            daList.Fill(dsList, "Musica"); //Fill the list with the table
            
            //Show dsLint on dataGridView1
            dataGridView1.DataSource = dsList; 
            dataGridView1.DataMember = "Musica";

            conecc.Cerrar();
        }        
    }
}

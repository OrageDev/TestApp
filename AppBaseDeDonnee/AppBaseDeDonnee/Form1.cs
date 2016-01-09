//Created By Orage

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBaseDeDonnee
{
    public partial class Form1 : Form
    {
        private string rq_sql;                              //Objet string qui contiendra les requêtes SQL
        private string cnx;                                 //Object string qui contiendra la clé de connection a la BDD
        private System.Data.OleDb.OleDbConnection oCNX;     //Objet Connection de BDD
        private System.Data.OleDb.OleDbCommand oCMD;        //Objet Command qui executera une requête SQL
        private System.Data.OleDb.OleDbDataAdapter oDA;     //Objet DataAdapter qui fait le lien entre l'application et la BDD
        private System.Data.DataSet oDS;                    //Objet qui stock en local les informations de la BDD

        public Form1()
        {
            InitializeComponent();
            Form1_Load();
            
        }

        //##########################################################
        //#            Changer l'emplacement de la BDD             #
        //##########################################################
        private void Form1_Load()
        {
            this.rq_sql = null;
                                                                          //Changer l'emplacement ou ce trouve votre BDD
            this.cnx = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Orage\Documents\Visual Studio 2015\Projects\AppBaseDeDonnee\AppBaseDeDonnee\MyBDD.mdb";
            this.oCNX = new System.Data.OleDb.OleDbConnection(this.cnx);  
            this.oCMD = null;
            this.oDA = null;
            this.oDS = new DataSet();
            this.m_select();
        }

        private void m_select()
        {
            this.oDS = new DataSet();
            this.rq_sql = "SELECT * FROM TB_PERSONNE;";                              //Requête SELECT Paramétrée
            this.oCMD = new System.Data.OleDb.OleDbCommand(this.rq_sql, this.oCNX);  //Création d'un objet commande qui prend en paramètre la requête SQL et la l'objet de Connexion a la BDD.
            this.oDA = new System.Data.OleDb.OleDbDataAdapter(this.oCMD);            //Création d'un objet DataAdapter qui prend en paramètre l'objet commande. (DataAdapter et l'interface réel entre l'application et la BDD.
            this.oDA.Fill(this.oDS, "personne");                                     //Execution de la requête SQL, si retournes des enregistrements, elle sont placé dans l'objet DataSet, dans la DataTable "Personne".
            this.dataGridView1.DataSource = this.oDS;                                //On attribue le modèle de mon DataSet au gridview pour afficher mes enregistrement.
            this.dataGridView1.DataMember = "personne";                              //Mais bien définir la table a afficher, car le DataSet peut en contenir plusieur.
        }

        //Mode Personnel de suppression.
        private void checkbox_delete_CheckedChanged(object sender, EventArgs e)
        {

            
            if(checkbox_delete.Checked == true) // Si Actif.
            {
                btn_delete.Enabled = true; //Active le bouton Delete.
                this.label1.Text = "Entrer le nom de la personne a supprimer."; // Change le Label.
                btn_insert.Enabled = false; //Désactive le bouton Insert.
            }
            if(checkbox_delete.Checked == false) // Si non Actif.
            {
                btn_delete.Enabled = false; // Desactive le bouton Delete.
                this.label1.Text = "Entrer le nom et le prenom de la personne a enregistrer."; // Change le Label.
                btn_insert.Enabled = true; // Active le bouton Insert
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            this.m_select();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

            if (this.txtbox_nom.Text == "" || this.txtbox_prenom.Text == "")
            {
                MessageBox.Show("Veuillez entrer le NOM et le PRENOM de la personne que vous voulez ajouter.");
            }
            else
            {
                this.rq_sql = "INSERT INTO TB_PERSONNE ([Nom_personne], [Prenom_personne]) VALUES ('" + this.txtbox_nom.Text + "','" + this.txtbox_prenom.Text + "');";
                this.oCMD = new System.Data.OleDb.OleDbCommand(this.rq_sql, this.oCNX);
                this.oCNX.Open();
                this.oCMD.ExecuteNonQuery();
                this.oCNX.Close();
                MessageBox.Show("Votre utilisateur a été correctement ajouté.");
                this.m_select();

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.txtbox_nom.Text == "" || this.txtbox_prenom.Text == "")
            {
                MessageBox.Show("Veuillez entrer le NOM et le PRENOM de la personne que vous voulez supprimer");
            }
            else
            {
                this.rq_sql = "DELETE FROM `TB_PERSONNE` WHERE `Nom_personne` = '" + this.txtbox_nom.Text + "' AND `Prenom_personne` = '" + this.txtbox_prenom.Text + "'";
                this.oCMD = new System.Data.OleDb.OleDbCommand(this.rq_sql, this.oCNX);
                this.oCNX.Open();
                this.oCMD.ExecuteNonQuery();
                this.oCNX.Close();
                MessageBox.Show("Votre utilisateur a été correctement supprimé.");
                this.m_select();
            }
        }

    }
}

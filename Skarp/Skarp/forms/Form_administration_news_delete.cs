using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skarp.forms {
    public partial class Form_administration_news_delete : Form {

        News allNews;
        DataSet dataSetAllNews;


        public Form_administration_news_delete () {
            InitializeComponent();

            // chargement datas
            allNews = new News();
            dataSetAllNews = allNews.getAllNews();

            foreach ( DataRow rw in dataSetAllNews.Tables["News"].Rows ) {

                cb_titre_news.Items.Add( rw["titre"].ToString() );

            }

        }

        private void cb_titre_news_SelectedIndexChanged ( object sender , EventArgs e ) {

            foreach ( DataRow rw in dataSetAllNews.Tables["News"].Rows ) {

                if ( rw["titre"].ToString() == cb_titre_news.Text ) {

                    allNews.ID = Convert.ToInt32( rw["idNews"] );
                    tb_auteur.Text = rw["auteur"].ToString();
                    tb_message.Text = rw["message"].ToString();
                    break;

                }

            }



        }

        private void button_sauvegarder_Click ( object sender , EventArgs e ) {

            if ( allNews.delete() ) {
                MessageBox.Show( Traducteur.traduction_[66] );
            } else {
                MessageBox.Show( Traducteur.traduction_[67] );
            }

            cb_titre_news.Items.Remove(cb_titre_news.Text);
            cb_titre_news.Text = "";
            tb_auteur.Clear();
            tb_message.Clear();

        }
    }
}

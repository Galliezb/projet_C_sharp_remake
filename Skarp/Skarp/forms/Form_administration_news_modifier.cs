using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;

namespace Skarp.forms {

    public partial class Form_administration_news_modifier : Form {

        News allNews;
        DataSet dataSetAllNews;
        int ligneLu = 0;

        public Form_administration_news_modifier () {
            InitializeComponent();

            // chargement datas
            allNews = new News();
            dataSetAllNews = allNews.getAllNews();

            reloadDataComboTitre();

        }

        private void cb_titre_news_SelectedIndexChanged ( object sender , EventArgs e ) {

            foreach ( DataRow rw in dataSetAllNews.Tables["News"].Rows ) {

                if ( rw["titre"].ToString() == cb_titre_news.Text ) {

                    allNews.ID = Convert.ToInt32( rw["idNews"] );
                    allNews.auteur = rw["auteur"].ToString();
                    allNews.titre = rw["titre"].ToString();
                    allNews.dateCreation = Convert.ToDateTime( rw["dateCreation"].ToString());
                    allNews.language = rw["language"].ToString();
                    cb_language.SelectedText = rw["language"].ToString();
                    tb_message.Text = rw["message"].ToString();
                    break;

                }

                ligneLu++;

            }

        }

        private void button_sauvegarder_Click ( object sender , EventArgs e ) {

            allNews.titre = cb_titre_news.Text;
            allNews.message = tb_message.Text;
            allNews.language = cb_language.Text;
            

            if ( allNews.update() ) {

                MessageBox.Show( Traducteur.traduction_[64] );
                dataSetAllNews.Tables["News"].Rows[ligneLu]["titre"] = cb_titre_news.Text;
                dataSetAllNews.Tables["News"].Rows[ligneLu]["message"] = tb_message;
                dataSetAllNews.Tables["News"].Rows[ligneLu]["language"] = cb_language;
                ligneLu = 0;
                reloadDataComboTitre();
                cb_titre_news.Text = "";
                tb_message.Clear();

            } else {
                MessageBox.Show( Traducteur.traduction_[65] );
            }

        }

        public void reloadDataComboTitre () {

            cb_titre_news.Items.Clear();
            foreach ( DataRow rw in dataSetAllNews.Tables["News"].Rows ) {

                cb_titre_news.Items.Add( rw["titre"].ToString() );

            }


        }

    }
}

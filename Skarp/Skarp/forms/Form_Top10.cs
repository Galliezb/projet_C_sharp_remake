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
    public partial class Form_Top10 : Form {
        public Form_Top10 () {
            InitializeComponent();
            axShockwaveFlash1.Visible = false;
            tbDescription.ForeColor = Color.White;
        }

        private void treeView1_AfterSelect ( object sender , TreeViewEventArgs e ) {
            


        }

        private void panel1_Leave ( object sender , EventArgs e ) {

        }

        private void panel1_Leave ( object sender , PaintEventArgs e ) {

        }

        private void panel1_Leave ( object sender , FormClosedEventArgs e ) {

        }

        private void GameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GameList.SelectedItem.ToString() == "League of Legends")
            {

                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/fjrfYZsZLJA";

                tbDescription.Text = "Dans les Champs de justice, la victoire dépend de plusieurs facteurs. Dans le guide du débutant, vous apprendrez à contrôler votre champion, à connaître les bâtiments dispersés sur le champ de bataille et vous verrez aussi le didacticiel. Une fois prêt, vous pourrez rejoindre le combat dans votre première partie compétitive de League of Legends.";
            }
            if (GameList.SelectedItem.ToString() == "Battlerite")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/f5Q041c0Sis";
                //
                tbDescription.Text = "Battlerite is an action-packed Team Arena Brawler focused on competitive PvP combat. Fight side by side with teammates to the sound of the roaring crowd in vibrant, colosseum-style surroundings. Welcome to a world where champions dedicate their lives to the arena.";

            }
            if (GameList.SelectedItem.ToString() == "BattleBorn")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/7G4jIm5Dj8Y";
                //
                tbDescription.Text = "Une bande de héros survitaminés aux pouvoirs extraordinaires lutte pour la protection de la dernière étoile de l'univers, menacée par un mal mystérieux. Pour vous battre, vous pourrez compter sur des personnages et des armes d'une variété inimaginable : cyborgs hommes-oiseaux, vampires samouraïs, montagnes de muscles équipées de sulfateuses.";
            }
            if (GameList.SelectedItem.ToString() == "Counter Strike GO")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/edYCtaNueQY";
                //
                tbDescription.Text = "Counter-Strike: Global Offensive (CS:GO) expands upon the team-based action gameplay that the franchise pioneered when it was launched 12 years ago.CS:GO features new maps, characters, and weapons and delivers updated versions of the classic CS content (de_dust, etc.). In addition, CS:GO introduces new gameplay modes, matchmaking, leader boards, and more.  ";
            }
            if (GameList.SelectedItem.ToString() == "Dota2")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/Ii_EjA7bqYw";

                tbDescription.Text = "Dota 2 se joue en matchs indépendants opposant deux équipes de cinq joueurs, chacune possédant une base située en coin de carte contenant un bâtiment appelé l'« Ancient », dont la destruction mène à la victoire de l'équipe ennemie. Chaque joueur contrôle un « Héros » et est amené à accumuler de l’expérience, gagner de l'or, s'équiper d'objets et combattre l'équipe ennemie pour parvenir à la victoire.";
            }
            if (GameList.SelectedItem.ToString() == "Overwatch")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/FqnKB22pOC0";

                tbDescription.Text = "Dans Overwatch, vous contrôlez un héros dans des parties compétitives opposant des équipes de 6 personnes. Livrez bataille pour contrôler des objectifs, éliminez l’équipe ennemie et savourez votre victoire.";
            }
            if (GameList.SelectedItem.ToString() == "Heavy Metal Machine")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/eNhNj9klFss";

                tbDescription.Text = "L'apocalypse touche à sa fin, et il ne reste que les Heavy Metal Machines. Bienvenue dans un monde de folie motorisée, où seuls les plus forts sortiront indemnes du chaos et de la destruction incessants. Vous devrez décimer vos ennemis pour vous en sortir.";
            }
            if (GameList.SelectedItem.ToString() == "Paladin")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/dEwEC2MKgeQ";

                tbDescription.Text = "Paladins est un jeu de tir en équipe combinant des éléments de stratégie à un système de personnalisation de personnages unique via des cartes à collectionner. Ces cartes permettent d'améliorer et de renforcer les compétences d'un champion de nombreuses façons. ";
            }
            if (GameList.SelectedItem.ToString() == "Hearthstone")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/MG3nb7Oam4k";

                tbDescription.Text = "sortez votre deck et préparez-vous pour Hearthstone. Les règles de ce jeu de cartes et de stratégie sont simples, mais vous pouvez vous attendre à des défis épiques et intenses ! Jouez gratuitement, utilisez vos cartes pour jeter des sorts, invoquer des créatures et donner des ordres aux héros de Warcraft lors de duels légendaires et stratégiques";
            }
            if (GameList.SelectedItem.ToString() == "Orion Prelude")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/Rt6tM72XSYM";

                tbDescription.Text = "ORION Dino Horde est un jeu de tir disponible en téléchargement sur PC. Il s'agit d'une version améliorée du jeu de base, ORION : Dino Beatdown offrant 5 modes de jeu supplémentaires, de nouvelles armes et des améliorations supplémentaires.";
            }
        }
    }
}

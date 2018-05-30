using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// L'espace de noms System.Collections.Generic contient des interfaces et des classes qui définissent des collections génériques permettant 
//aux utilisateurs de créer des collections fortement typées. Celles-ci fournissent une sécurité et des performances meilleures que 
// les collections fortement typées non génériques
//L'espace de noms System.ComponentModel fournit des classes qui sont utilisées pour implémenter le comportement d’exécution et au moment 
// du design des composants et des contrôles. Cet espace de noms inclut les classes de base et les interfaces pour 
// l’implémentation des attributs et des convertisseurs de type, liaison à des données sources et les licences des composants.
// L'espace de noms System.Data permet d'accéder à des classes qui représentent l'architecture ADO.NET
// ADO.NET permet de construire des composants qui gèrent efficacement les données provenant de plusieurs sources.
// L'espace de noms System.Drawing donne accès aux fonctionnalités graphiques de base GDI+.
// L’espace de noms System.Linq fournit des classes et interfaces qui prennent en charge les requêtes qui utilisent 
// Language-Integrated Query (LINQ).
// L’espace de noms System.Text contient des classes représentant des encodages de caractères ASCII et Unicode, des classes de base abstraites 
// pour la conversion de blocs de caractères vers et à partir des blocs d’octets et une classe d’assistance qui manipule et met en forme 
// les objets String sans créer d’instances intermédiaires de String.
// L'espace de noms System.Threading.Tasks fournit des types qui simplifient le travail d’écriture de code simultané et asynchrone. 
// L'espace de noms System.Windows.Forms contient des classes pour créer des applications Windows qui tirent pleinement parti de 
// de la richesse desfonctionnalités d’interface disponibles dans le système d’exploitation Microsoft Windows.

namespace Calculatrice
{
    public partial class calculatrice : Form  // partial signifie que la classe est définie à plusieurs endroits
    { // ici on ne voit que ce qu'on doit toucher 
        public calculatrice()
        {
            InitializeComponent(); // initialise tous les composants sur le formulaire pour qu'il puisse apparaître correctement
        }
        string operateur;
        private void textBox1_TextChanged(object sender, EventArgs e) // EventArgs représente la classe de base pour les classes 
        // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
        // pas de données d’événement.
        {

        }

        private void button12_Click(object sender, EventArgs e) // EventArgs représente la classe de base pour les classes 
        // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
        // pas de données d’événement.
        {

        }

        private void button1_Click(object sender, EventArgs e) // EventArgs représente la classe de base pour les classes 
        // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
        // pas de données d’événement.
        {
            textBox_resultat.Text += "1"; // permet d’afficher sur l’écran un numéro donné correspondant au bouton sur lequel on clique
        }

        private void button2_Click(object sender, EventArgs e) // EventArgs représente la classe de base pour les classes 
        // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
        // pas de données d’événement.
        {
            textBox_resultat.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        { // EventArgs représente la classe de base pour les classes 
          // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
          // pas de données d’événement.
            textBox_resultat.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        { // EventArgs représente la classe de base pour les classes 
          // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
          // pas de données d’événement.
            textBox_resultat.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        { // EventArgs représente la classe de base pour les classes 
          // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
          // pas de données d’événement.
            textBox_resultat.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        { // EventArgs représente la classe de base pour les classes 
          // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
          // pas de données d’événement.
            textBox_resultat.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        { // EventArgs représente la classe de base pour les classes 
          // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
          // pas de données d’événement.
            textBox_resultat.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        { // EventArgs représente la classe de base pour les classes 
          // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
          // pas de données d’événement.
            textBox_resultat.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        { // EventArgs représente la classe de base pour les classes 
          // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
          // pas de données d’événement.
            textBox_resultat.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        { // EventArgs représente la classe de base pour les classes 
          // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
          // pas de données d’événement.
            textBox_resultat.Text += "0";
        }

        private void button_virgule_Click(object sender, EventArgs e)
        { // EventArgs représente la classe de base pour les classes 
          // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
          // pas de données d’événement.
            textBox_resultat.Text += ",";
        }

        private void button_plus_Click(object sender, EventArgs e)
        { // EventArgs représente la classe de base pour les classes 
          // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
          // pas de données d’événement.
            textBox_resultat.Text += "+";
            operateur = "+"; // la variable de type string nommée « operateur » stocke la valeur choisie par l’utilisateur
        }

        private void button_moin_Click(object sender, EventArgs e)
        { // EventArgs représente la classe de base pour les classes 
          // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
          // pas de données d’événement.
            textBox_resultat.Text += "-";
            operateur = "-";
        }

        private void button_multiple_Click(object sender, EventArgs e)
        { // EventArgs représente la classe de base pour les classes 
          // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
          // pas de données d’événement.
            textBox_resultat.Text += "*";
            operateur = "*";
        }

        private void button_division_Click(object sender, EventArgs e)// EventArgs représente la classe de base pour les classes 
        // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
        // pas de données d’événement.
        {
            textBox_resultat.Text += "/";
            operateur = "/";
        }

        private void button_effacer_Click(object sender, EventArgs e) // EventArgs représente la classe de base pour les classes 
        // qui contiennent des données d’événement et fournit une valeur à utiliser pour les événements qui ne contiennent 
        // pas de données d’événement.
        {
            textBox_resultat.Clear(); // permet d’effacer simultanément l’ensemble des valeurs affichées sur l’écran de la calculatrice
        }

        private void button_egale_Click(object sender, EventArgs e) // Le bouton "egale" permet de vérifier les variables opérateur
        { // Pour chaque opérateur "+", "-", "*", "/", il faut programmer une condition if qui permettra de rendre fonctionnel l’opérateur 
        // sur lequel on clique.
            if (operateur == "+")
            {
                string[] chaine = textBox_resultat.Text.Split('+');
                // la ligne « Environment.NewLine » permet le retour à la ligne
                textBox_resultat.Text += Environment.NewLine + "=" + Environment.NewLine + (double.Parse(chaine[0]) + double.Parse(chaine[1])).ToString();
                // double.Parse() convertit la représentation sous forme de chaîne d'un nombre en nombre à virgule flottante double précision équivalent
            }
            if (operateur == "-")
            {
                string[] chaine = textBox_resultat.Text.Split('-');

                textBox_resultat.Text += Environment.NewLine + "=" + Environment.NewLine + (double.Parse(chaine[0]) - double.Parse(chaine[1])).ToString();
            }
            if (operateur == "*")
            {
                string[] chaine = textBox_resultat.Text.Split('*');
                // La variable string chaine, stockant la valeur, se trouve dans le textBox_resultat.Text.
                // On récupère les valeurs de la chaine puis on convertit ces mêmes valeurs pour les afficher dans le Textbox.
                textBox_resultat.Text += Environment.NewLine + "=" + Environment.NewLine + (double.Parse(chaine[0]) * double.Parse(chaine[1])).ToString();
            }
            if (operateur == "/")
            {
                string[] chaine = textBox_resultat.Text.Split('/');
                if(double.Parse(chaine[1]) != 0) // La condition pour que l’opération de division puisse s’effectuer, 
                // le dénominateur doit être différent de zéro. 
                {
                    // la ligne « Environment.NewLine » permet le retour à la ligne
                    textBox_resultat.Text += Environment.NewLine + "=" + Environment.NewLine + (double.Parse(chaine[0]) / double.Parse(chaine[1])).ToString();
                }
                else 
                {
                   // Dans le cas où le dénominateur est nul, l’instruction « else » sera effective, 
                   // ainsi le message d’erreur suivant s’affichera: « la division sur 0 est impossible ».
                    textBox_resultat.Text += Environment.NewLine + "=" + Environment.NewLine + "la division sur 0 est impossible";
   
                }
            }
        }

        private void calculatrice_Load(object sender, EventArgs e)
        {

        }
    }
}

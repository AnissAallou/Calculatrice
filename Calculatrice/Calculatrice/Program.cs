using System;
using System.Collections.Generic; 
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
// L'espace de noms System.Collections.Generic contient des interfaces et des classes qui définissent des collections génériques permettant 
//aux utilisateurs de créer des collections fortement typées. Celles-ci fournissent une sécurité et des performances meilleures que 
// les collections fortement typées non génériques
// L’espace de noms System.Linq fournit des classes et interfaces qui prennent en charge les requêtes qui utilisent 
// Language-Integrated Query (LINQ).
// L'espace de noms System.Threading.Tasks fournit des types qui simplifient le travail d’écriture de code simultané et asynchrone. 
// L'espace de noms System.Windows.Forms contient des classes pour créer des applications Windows qui tirent pleinement parti de 
// de la richesse desfonctionnalités d’interface disponibles dans le système d’exploitation Microsoft Windows.

namespace Calculatrice
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread] // Indique que le modèle de thread COM d'une application est un modèle STA (Single-Threaded Apartment)
        static void Main()
        {
            Application.EnableVisualStyles(); // active les styles visuels (couleurs, polices etc...) pour l'application. 
            // Les styles visuels forment un thème de système d'exploitation.
            // Les contrôles dessineront avec des styles visuels si le contrôle et le système d'exploitation le prennent en charge. 
            // Pour avoir un effet, Application.EnableVisualStyles doit être appelé avant de créer des contrôles dans l'application
            // généralement, Application.EnableVisualStyles est la première ligne de la fonction principale.
            Application.SetCompatibleTextRenderingDefault(false); // définit la valeur par défaut de l'application sur certains contrôles.
            Application.Run(new calculatrice()); // commence à exécuter une boucle de messages d'application standard sur le thread en cours
        }
    }
}

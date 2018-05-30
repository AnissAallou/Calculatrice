namespace Calculatrice
{
    partial class calculatrice
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null; // l'interface IContainer fournit les fonctionnalités pour les conteneurs
        // Les conteneurs sont des objets qui contiennent logiquement zéro ou plusieurs composants
        // Les lignes qui commencent par trois slashes (barres obliques) sont des lignes de commentaires spéciaux
        // Ces commentaires sont utilisés pour l'IntelliSense
        // c'est une fonction d' achèvement de code contextuelle dans certains environnements de programmation qui 
        // accélère le processus de codage des applications en réduisant les fautes de frappe et autres erreurs courantes
        // IntelliSense supprime les membres inutiles de la liste de saisie semi-automatique à l'aide de filtres
        // Entre deux balises « summary », on décrit brièvement à quoi sert ce qui suit (ce peut être une classe, une méthode, ...) en anglais
        // Si c'est une méthode qui prend en entrée des arguments, on peut détailler ce que chacun représente avec des balises « param ».
        /// <summary> // les commentaires sont faits avec des balises 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            { // disposer le formulaire et ses composants contenus
                components.Dispose(); // libère toutes les ressources utilisées par les composants
            }
            base.Dispose(disposing); // implémentez une méthode Dispose pour libérer les ressources non managées 
            // utilisées par l'application
        }
        // #region démarre le bloc et #endregion le termine
        #region Code généré par le Concepteur Windows Form 
    

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {            this.textBox_resultat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_virgule = new System.Windows.Forms.Button();
            this.button_effacer = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_moin = new System.Windows.Forms.Button();
            this.button_multiple = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_egale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_resultat
            // 
            this.textBox_resultat.Location = new System.Drawing.Point(12, 12);
            this.textBox_resultat.Name = "textBox_resultat";
            this.textBox_resultat.Size = new System.Drawing.Size(258, 22);
            this.textBox_resultat.TabIndex = 0;
            this.textBox_resultat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(80, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 45);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(147, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 45);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 157);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 45);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(80, 159);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 45);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(147, 157);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(61, 45);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(80, 208);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(61, 45);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button_virgule
            // 
            this.button_virgule.Location = new System.Drawing.Point(12, 208);
            this.button_virgule.Name = "button_virgule";
            this.button_virgule.Size = new System.Drawing.Size(61, 45);
            this.button_virgule.TabIndex = 11;
            this.button_virgule.Text = ".";
            this.button_virgule.UseVisualStyleBackColor = true;
            this.button_virgule.Click += new System.EventHandler(this.button_virgule_Click);
            // 
            // button_effacer
            // 
            this.button_effacer.Location = new System.Drawing.Point(214, 55);
            this.button_effacer.Name = "button_effacer";
            this.button_effacer.Size = new System.Drawing.Size(61, 31);
            this.button_effacer.TabIndex = 16;
            this.button_effacer.Text = "C";
            this.button_effacer.UseVisualStyleBackColor = true;
            this.button_effacer.Click += new System.EventHandler(this.button_effacer_Click);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(214, 106);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(61, 31);
            this.button_plus.TabIndex = 17;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_moin
            // 
            this.button_moin.Location = new System.Drawing.Point(214, 143);
            this.button_moin.Name = "button_moin";
            this.button_moin.Size = new System.Drawing.Size(61, 31);
            this.button_moin.TabIndex = 18;
            this.button_moin.Text = "-";
            this.button_moin.UseVisualStyleBackColor = true;
            this.button_moin.Click += new System.EventHandler(this.button_moin_Click);
            // 
            // button_multiple
            // 
            this.button_multiple.Location = new System.Drawing.Point(214, 185);
            this.button_multiple.Name = "button_multiple";
            this.button_multiple.Size = new System.Drawing.Size(61, 31);
            this.button_multiple.TabIndex = 19;
            this.button_multiple.Text = "*";
            this.button_multiple.UseVisualStyleBackColor = true;
            this.button_multiple.Click += new System.EventHandler(this.button_multiple_Click);
            // 
            // button_division
            // 
            this.button_division.Location = new System.Drawing.Point(214, 222);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(61, 31);
            this.button_division.TabIndex = 20;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_division_Click);
            // 
            // button_egale
            // 
            this.button_egale.Location = new System.Drawing.Point(147, 208);
            this.button_egale.Name = "button_egale";
            this.button_egale.Size = new System.Drawing.Size(61, 45);
            this.button_egale.TabIndex = 21;
            this.button_egale.Text = "=";
            this.button_egale.UseVisualStyleBackColor = true;
            this.button_egale.Click += new System.EventHandler(this.button_egale_Click);
            // 
            // calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 306);
            this.Controls.Add(this.button_egale);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_multiple);
            this.Controls.Add(this.button_moin);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_effacer);
            this.Controls.Add(this.button_virgule);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_resultat);
            this.Name = "calculatrice";
            this.Text = "Calculatrice";
            this.Load += new System.EventHandler(this.calculatrice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_resultat; // représente un contrôle de zone de texte Windows
        private System.Windows.Forms.Button button1; // représente un contrôle de bouton Windows
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_virgule;
        private System.Windows.Forms.Button button_effacer;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_moin;
        private System.Windows.Forms.Button button_multiple;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_egale;
    }
}


namespace Pokladna_Pavel
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvData = new System.Windows.Forms.ListView();
            this.idDoklad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cislo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.popis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.castka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zustatek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.poznamka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rokCombo = new System.Windows.Forms.ComboBox();
            this.mesicCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mesicCombo);
            this.panel1.Controls.Add(this.rokCombo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(569, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 666);
            this.panel1.TabIndex = 0;
            // 
            // lvData
            // 
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idDoklad,
            this.cislo,
            this.datum,
            this.popis,
            this.castka,
            this.zustatek,
            this.poznamka});
            this.lvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvData.HideSelection = false;
            this.lvData.Location = new System.Drawing.Point(0, 0);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(569, 666);
            this.lvData.TabIndex = 0;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // idDoklad
            // 
            this.idDoklad.Text = "Č. dokladu";
            // 
            // cislo
            // 
            this.cislo.Text = "Číslo";
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            // 
            // popis
            // 
            this.popis.Text = "Popis";
            // 
            // castka
            // 
            this.castka.Text = "Částka";
            // 
            // zustatek
            // 
            this.zustatek.Text = "Zůstatek";
            // 
            // poznamka
            // 
            this.poznamka.Text = "Poznámka";
            // 
            // rokCombo
            // 
            this.rokCombo.FormattingEnabled = true;
            this.rokCombo.Location = new System.Drawing.Point(21, 104);
            this.rokCombo.Name = "rokCombo";
            this.rokCombo.Size = new System.Drawing.Size(157, 28);
            this.rokCombo.TabIndex = 1;
            this.rokCombo.SelectedIndexChanged += new System.EventHandler(this.rokCombo_SelectedIndexChanged);
            // 
            // mesicCombo
            // 
            this.mesicCombo.FormattingEnabled = true;
            this.mesicCombo.Location = new System.Drawing.Point(21, 167);
            this.mesicCombo.Name = "mesicCombo";
            this.mesicCombo.Size = new System.Drawing.Size(157, 28);
            this.mesicCombo.TabIndex = 2;
            this.mesicCombo.SelectedIndexChanged += new System.EventHandler(this.mesicCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Výběr období";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Měsíc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 666);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader idDoklad;
        private System.Windows.Forms.ColumnHeader popis;
        private System.Windows.Forms.ColumnHeader castka;
        private System.Windows.Forms.ColumnHeader zustatek;
        private System.Windows.Forms.ColumnHeader poznamka;
        private System.Windows.Forms.ColumnHeader cislo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mesicCombo;
        private System.Windows.Forms.ComboBox rokCombo;
    }
}


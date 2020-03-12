namespace TransportGUI
{
    partial class Ort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAbfahrtsPlan = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchStation = new System.Windows.Forms.Button();
            this.ddlStations = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAbfahrtsPlan
            // 
            this.btnAbfahrtsPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbfahrtsPlan.Location = new System.Drawing.Point(12, 112);
            this.btnAbfahrtsPlan.Name = "btnAbfahrtsPlan";
            this.btnAbfahrtsPlan.Size = new System.Drawing.Size(75, 23);
            this.btnAbfahrtsPlan.TabIndex = 4;
            this.btnAbfahrtsPlan.Text = "Abfahrtsplan";
            this.btnAbfahrtsPlan.UseVisualStyleBackColor = true;
            this.btnAbfahrtsPlan.Click += new System.EventHandler(this.BtnAbfahrtsPlan_Click);
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(108, 112);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(75, 23);
            this.btnAbfahrtstafel.TabIndex = 5;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.BtnAbfahrtstafel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(211, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Station suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnSearchStation
            // 
            this.btnSearchStation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchStation.Location = new System.Drawing.Point(12, 38);
            this.btnSearchStation.Name = "btnSearchStation";
            this.btnSearchStation.Size = new System.Drawing.Size(173, 23);
            this.btnSearchStation.TabIndex = 2;
            this.btnSearchStation.Text = "Passende Station suchen";
            this.btnSearchStation.UseVisualStyleBackColor = true;
            this.btnSearchStation.Click += new System.EventHandler(this.BtnSearchStation_Click);
            // 
            // ddlStations
            // 
            this.ddlStations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlStations.FormattingEnabled = true;
            this.ddlStations.Location = new System.Drawing.Point(12, 10);
            this.ddlStations.Name = "ddlStations";
            this.ddlStations.Size = new System.Drawing.Size(173, 21);
            this.ddlStations.TabIndex = 1;
            // 
            // Ort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 147);
            this.Controls.Add(this.ddlStations);
            this.Controls.Add(this.btnSearchStation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAbfahrtstafel);
            this.Controls.Add(this.btnAbfahrtsPlan);
            this.Name = "Ort";
            this.Text = "Ort";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ort_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbfahrtsPlan;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSearchStation;
        private System.Windows.Forms.ComboBox ddlStations;
    }
}
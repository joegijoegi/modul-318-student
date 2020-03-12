namespace TransportGUI
{
    partial class Abfahrtstafel
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
            this.lblStation = new System.Windows.Forms.Label();
            this.ddlStartStation = new System.Windows.Forms.ComboBox();
            this.btnSearchStation = new System.Windows.Forms.Button();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.dgvAbfahrtsTafel = new System.Windows.Forms.DataGridView();
            this.Abfahrtsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAbfahrtsplan = new System.Windows.Forms.Button();
            this.btnOrtStation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtsTafel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(12, 9);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(43, 13);
            this.lblStation.TabIndex = 0;
            this.lblStation.Text = "Station:";
            // 
            // ddlStartStation
            // 
            this.ddlStartStation.FormattingEnabled = true;
            this.ddlStartStation.Location = new System.Drawing.Point(67, 6);
            this.ddlStartStation.Name = "ddlStartStation";
            this.ddlStartStation.Size = new System.Drawing.Size(289, 21);
            this.ddlStartStation.TabIndex = 1;
            // 
            // btnSearchStation
            // 
            this.btnSearchStation.Location = new System.Drawing.Point(67, 42);
            this.btnSearchStation.Name = "btnSearchStation";
            this.btnSearchStation.Size = new System.Drawing.Size(289, 23);
            this.btnSearchStation.TabIndex = 2;
            this.btnSearchStation.Text = "Passende Station suchen";
            this.btnSearchStation.UseVisualStyleBackColor = true;
            this.btnSearchStation.Click += new System.EventHandler(this.BtnSearchStation_Click);
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(427, 4);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(267, 23);
            this.btnSearchConnection.TabIndex = 3;
            this.btnSearchConnection.Text = "Verbindung suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.BtnSearchConnection_Click);
            // 
            // dgvAbfahrtsTafel
            // 
            this.dgvAbfahrtsTafel.AllowUserToAddRows = false;
            this.dgvAbfahrtsTafel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAbfahrtsTafel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbfahrtsTafel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAbfahrtsTafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbfahrtsTafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrtsort,
            this.Abfahrtszeit,
            this.Ankunftsort,
            this.Ankunftszeit,
            this.Gleis});
            this.dgvAbfahrtsTafel.Location = new System.Drawing.Point(15, 87);
            this.dgvAbfahrtsTafel.Name = "dgvAbfahrtsTafel";
            this.dgvAbfahrtsTafel.ReadOnly = true;
            this.dgvAbfahrtsTafel.RowHeadersVisible = false;
            this.dgvAbfahrtsTafel.Size = new System.Drawing.Size(679, 315);
            this.dgvAbfahrtsTafel.TabIndex = 8;
            this.dgvAbfahrtsTafel.TabStop = false;
            // 
            // Abfahrtsort
            // 
            this.Abfahrtsort.HeaderText = "Abfahrtsort";
            this.Abfahrtsort.Name = "Abfahrtsort";
            this.Abfahrtsort.ReadOnly = true;
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.HeaderText = "Abfahrtszeit";
            this.Abfahrtszeit.Name = "Abfahrtszeit";
            this.Abfahrtszeit.ReadOnly = true;
            // 
            // Ankunftsort
            // 
            this.Ankunftsort.HeaderText = "Ankunftsort";
            this.Ankunftsort.Name = "Ankunftsort";
            this.Ankunftsort.ReadOnly = true;
            // 
            // Ankunftszeit
            // 
            this.Ankunftszeit.HeaderText = "Operator";
            this.Ankunftszeit.Name = "Ankunftszeit";
            this.Ankunftszeit.ReadOnly = true;
            // 
            // Gleis
            // 
            this.Gleis.HeaderText = "Zug- / Busname";
            this.Gleis.Name = "Gleis";
            this.Gleis.ReadOnly = true;
            // 
            // btnAbfahrtsplan
            // 
            this.btnAbfahrtsplan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbfahrtsplan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbfahrtsplan.Location = new System.Drawing.Point(15, 417);
            this.btnAbfahrtsplan.Name = "btnAbfahrtsplan";
            this.btnAbfahrtsplan.Size = new System.Drawing.Size(96, 23);
            this.btnAbfahrtsplan.TabIndex = 4;
            this.btnAbfahrtsplan.Text = "Abfahrtsplan";
            this.btnAbfahrtsplan.UseVisualStyleBackColor = true;
            this.btnAbfahrtsplan.Click += new System.EventHandler(this.BtnAbfahrtsplan_Click);
            // 
            // btnOrtStation
            // 
            this.btnOrtStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOrtStation.Location = new System.Drawing.Point(117, 417);
            this.btnOrtStation.Name = "btnOrtStation";
            this.btnOrtStation.Size = new System.Drawing.Size(87, 23);
            this.btnOrtStation.TabIndex = 10;
            this.btnOrtStation.Text = "Ort von Station";
            this.btnOrtStation.UseVisualStyleBackColor = true;
            this.btnOrtStation.Click += new System.EventHandler(this.BtnOrtStation_Click);
            // 
            // Abfahrtstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAbfahrtsplan;
            this.ClientSize = new System.Drawing.Size(706, 452);
            this.Controls.Add(this.btnOrtStation);
            this.Controls.Add(this.btnAbfahrtsplan);
            this.Controls.Add(this.dgvAbfahrtsTafel);
            this.Controls.Add(this.btnSearchConnection);
            this.Controls.Add(this.btnSearchStation);
            this.Controls.Add(this.ddlStartStation);
            this.Controls.Add(this.lblStation);
            this.Name = "Abfahrtstafel";
            this.Text = "Abfahrtstafel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Abfahrtstafel_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtsTafel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.ComboBox ddlStartStation;
        private System.Windows.Forms.Button btnSearchStation;
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.DataGridView dgvAbfahrtsTafel;
        private System.Windows.Forms.Button btnAbfahrtsplan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
        private System.Windows.Forms.Button btnOrtStation;
    }
}
namespace TransportGUI
{
    partial class Abfahrtsplan
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.ddlStartStation = new System.Windows.Forms.ComboBox();
            this.ddlEndStation = new System.Windows.Forms.ComboBox();
            this.btnSearchStartStation = new System.Windows.Forms.Button();
            this.btnSearchEndStation = new System.Windows.Forms.Button();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.dgvAbfahrtsplan = new System.Windows.Forms.DataGridView();
            this.Abfahrtsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAbfahrtsTafel = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtsplan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 9);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(29, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Von:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(328, 9);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(36, 13);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "Nach:";
            // 
            // ddlStartStation
            // 
            this.ddlStartStation.FormattingEnabled = true;
            this.ddlStartStation.Location = new System.Drawing.Point(47, 6);
            this.ddlStartStation.Name = "ddlStartStation";
            this.ddlStartStation.Size = new System.Drawing.Size(275, 21);
            this.ddlStartStation.TabIndex = 1;
            // 
            // ddlEndStation
            // 
            this.ddlEndStation.FormattingEnabled = true;
            this.ddlEndStation.Location = new System.Drawing.Point(370, 6);
            this.ddlEndStation.Name = "ddlEndStation";
            this.ddlEndStation.Size = new System.Drawing.Size(275, 21);
            this.ddlEndStation.TabIndex = 3;
            // 
            // btnSearchStartStation
            // 
            this.btnSearchStartStation.Location = new System.Drawing.Point(47, 48);
            this.btnSearchStartStation.Name = "btnSearchStartStation";
            this.btnSearchStartStation.Size = new System.Drawing.Size(275, 23);
            this.btnSearchStartStation.TabIndex = 2;
            this.btnSearchStartStation.Text = "Passende Station suchen";
            this.btnSearchStartStation.UseVisualStyleBackColor = true;
            this.btnSearchStartStation.Click += new System.EventHandler(this.SearchStation_Click);
            // 
            // btnSearchEndStation
            // 
            this.btnSearchEndStation.Location = new System.Drawing.Point(370, 48);
            this.btnSearchEndStation.Name = "btnSearchEndStation";
            this.btnSearchEndStation.Size = new System.Drawing.Size(275, 23);
            this.btnSearchEndStation.TabIndex = 4;
            this.btnSearchEndStation.Text = "Passende Station suchen";
            this.btnSearchEndStation.UseVisualStyleBackColor = true;
            this.btnSearchEndStation.Click += new System.EventHandler(this.SearchStation_Click);
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(370, 88);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(275, 23);
            this.btnSearchConnection.TabIndex = 6;
            this.btnSearchConnection.Text = "Verbindung suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.BtnSearchConnection_Click);
            // 
            // dgvAbfahrtsplan
            // 
            this.dgvAbfahrtsplan.AllowUserToAddRows = false;
            this.dgvAbfahrtsplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAbfahrtsplan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbfahrtsplan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAbfahrtsplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbfahrtsplan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrtsort,
            this.Abfahrtszeit,
            this.Ankunftsort,
            this.Ankunftszeit,
            this.Gleis});
            this.dgvAbfahrtsplan.Location = new System.Drawing.Point(12, 139);
            this.dgvAbfahrtsplan.Name = "dgvAbfahrtsplan";
            this.dgvAbfahrtsplan.ReadOnly = true;
            this.dgvAbfahrtsplan.RowHeadersVisible = false;
            this.dgvAbfahrtsplan.Size = new System.Drawing.Size(633, 254);
            this.dgvAbfahrtsplan.TabIndex = 7;
            this.dgvAbfahrtsplan.TabStop = false;
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
            this.Ankunftszeit.HeaderText = "Ankunftszeit";
            this.Ankunftszeit.Name = "Ankunftszeit";
            this.Ankunftszeit.ReadOnly = true;
            // 
            // Gleis
            // 
            this.Gleis.HeaderText = "Gleis / Kante";
            this.Gleis.Name = "Gleis";
            this.Gleis.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(570, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Beenden";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnAbfahrtsTafel
            // 
            this.btnAbfahrtsTafel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbfahrtsTafel.Location = new System.Drawing.Point(12, 415);
            this.btnAbfahrtsTafel.Name = "btnAbfahrtsTafel";
            this.btnAbfahrtsTafel.Size = new System.Drawing.Size(75, 23);
            this.btnAbfahrtsTafel.TabIndex = 7;
            this.btnAbfahrtsTafel.Text = "Abfahrtstafel";
            this.btnAbfahrtsTafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtsTafel.Click += new System.EventHandler(this.BtnAbfahrtsTafel_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(47, 91);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(133, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // Abfahrtsplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnAbfahrtsTafel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvAbfahrtsplan);
            this.Controls.Add(this.btnSearchConnection);
            this.Controls.Add(this.btnSearchEndStation);
            this.Controls.Add(this.btnSearchStartStation);
            this.Controls.Add(this.ddlEndStation);
            this.Controls.Add(this.ddlStartStation);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Name = "Abfahrtsplan";
            this.Text = "Abfahrtsplan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtsplan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox ddlStartStation;
        private System.Windows.Forms.ComboBox ddlEndStation;
        private System.Windows.Forms.Button btnSearchStartStation;
        private System.Windows.Forms.Button btnSearchEndStation;
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.DataGridView dgvAbfahrtsplan;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAbfahrtsTafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}


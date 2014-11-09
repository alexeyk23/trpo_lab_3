namespace trpo_lab_3
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbxStrSource = new System.Windows.Forms.TextBox();
            this.txbxSubstr = new System.Windows.Forms.TextBox();
            this.grpAlgo = new System.Windows.Forms.GroupBox();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.rbBayerM = new System.Windows.Forms.RadioButton();
            this.rbKMP = new System.Windows.Forms.RadioButton();
            this.dgvRes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnClearSubstr = new System.Windows.Forms.Button();
            this.btnClearStr = new System.Windows.Forms.Button();
            this.btnClearRes = new System.Windows.Forms.Button();
            this.grpAlgo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Строка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Подстрока для поиска";
            // 
            // txbxStrSource
            // 
            this.txbxStrSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbxStrSource.Location = new System.Drawing.Point(13, 30);
            this.txbxStrSource.Name = "txbxStrSource";
            this.txbxStrSource.Size = new System.Drawing.Size(472, 26);
            this.txbxStrSource.TabIndex = 2;
            // 
            // txbxSubstr
            // 
            this.txbxSubstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbxSubstr.Location = new System.Drawing.Point(13, 86);
            this.txbxSubstr.Name = "txbxSubstr";
            this.txbxSubstr.Size = new System.Drawing.Size(354, 26);
            this.txbxSubstr.TabIndex = 3;
            // 
            // grpAlgo
            // 
            this.grpAlgo.Controls.Add(this.rbKMP);
            this.grpAlgo.Controls.Add(this.rbBayerM);
            this.grpAlgo.Controls.Add(this.rbSimple);
            this.grpAlgo.Location = new System.Drawing.Point(13, 125);
            this.grpAlgo.Name = "grpAlgo";
            this.grpAlgo.Size = new System.Drawing.Size(229, 111);
            this.grpAlgo.TabIndex = 4;
            this.grpAlgo.TabStop = false;
            this.grpAlgo.Text = "Алгоритмы";
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Checked = true;
            this.rbSimple.Location = new System.Drawing.Point(7, 20);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(80, 17);
            this.rbSimple.TabIndex = 0;
            this.rbSimple.TabStop = true;
            this.rbSimple.Text = "1. Простой";
            this.rbSimple.UseVisualStyleBackColor = true;
            // 
            // rbBayerM
            // 
            this.rbBayerM.AutoSize = true;
            this.rbBayerM.Location = new System.Drawing.Point(6, 49);
            this.rbBayerM.Name = "rbBayerM";
            this.rbBayerM.Size = new System.Drawing.Size(102, 17);
            this.rbBayerM.TabIndex = 1;
            this.rbBayerM.TabStop = true;
            this.rbBayerM.Text = "2. Бауэра-Мура";
            this.rbBayerM.UseVisualStyleBackColor = true;
            // 
            // rbKMP
            // 
            this.rbKMP.AutoSize = true;
            this.rbKMP.Location = new System.Drawing.Point(6, 78);
            this.rbKMP.Name = "rbKMP";
            this.rbKMP.Size = new System.Drawing.Size(153, 17);
            this.rbKMP.TabIndex = 2;
            this.rbKMP.TabStop = true;
            this.rbKMP.Text = "3. Кнута-Морриса-Пратта";
            this.rbKMP.UseVisualStyleBackColor = true;
            // 
            // dgvRes
            // 
            this.dgvRes.AllowUserToAddRows = false;
            this.dgvRes.AllowUserToDeleteRows = false;
            this.dgvRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvRes.Location = new System.Drawing.Point(248, 131);
            this.dgvRes.Name = "dgvRes";
            this.dgvRes.ReadOnly = true;
            this.dgvRes.Size = new System.Drawing.Size(344, 150);
            this.dgvRes.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Сравнения";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Сдвиги";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Индекс вхождения";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(15, 242);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(101, 39);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Поиск";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnClearSubstr
            // 
            this.btnClearSubstr.Location = new System.Drawing.Point(373, 86);
            this.btnClearSubstr.Name = "btnClearSubstr";
            this.btnClearSubstr.Size = new System.Drawing.Size(101, 26);
            this.btnClearSubstr.TabIndex = 7;
            this.btnClearSubstr.Text = "Очистить";
            this.btnClearSubstr.UseVisualStyleBackColor = true;
            // 
            // btnClearStr
            // 
            this.btnClearStr.Location = new System.Drawing.Point(491, 30);
            this.btnClearStr.Name = "btnClearStr";
            this.btnClearStr.Size = new System.Drawing.Size(101, 26);
            this.btnClearStr.TabIndex = 8;
            this.btnClearStr.Text = "Очистить";
            this.btnClearStr.UseVisualStyleBackColor = true;
            // 
            // btnClearRes
            // 
            this.btnClearRes.Location = new System.Drawing.Point(141, 242);
            this.btnClearRes.Name = "btnClearRes";
            this.btnClearRes.Size = new System.Drawing.Size(101, 39);
            this.btnClearRes.TabIndex = 9;
            this.btnClearRes.Text = "Очистить результатты";
            this.btnClearRes.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 293);
            this.Controls.Add(this.btnClearRes);
            this.Controls.Add(this.btnClearStr);
            this.Controls.Add(this.btnClearSubstr);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.dgvRes);
            this.Controls.Add(this.grpAlgo);
            this.Controls.Add(this.txbxSubstr);
            this.Controls.Add(this.txbxStrSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Поиск подстроки в строке";
            this.grpAlgo.ResumeLayout(false);
            this.grpAlgo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbxStrSource;
        private System.Windows.Forms.TextBox txbxSubstr;
        private System.Windows.Forms.GroupBox grpAlgo;
        private System.Windows.Forms.RadioButton rbKMP;
        private System.Windows.Forms.RadioButton rbBayerM;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.DataGridView dgvRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnClearSubstr;
        private System.Windows.Forms.Button btnClearStr;
        private System.Windows.Forms.Button btnClearRes;
    }
}


namespace Conways_Game_of_Life
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnPause = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lvTemplateSelection = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnLoadJson = new System.Windows.Forms.Button();
            this.lLoad = new System.Windows.Forms.Label();
            this.lSave = new System.Windows.Forms.Label();
            this.btnSaveJson = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lState = new System.Windows.Forms.Label();
            this.lCoordinates = new System.Windows.Forms.Label();
            this.btnPaint = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(3, 609);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(121, 62);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "Start";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // panelSidebar
            // 
            this.panelSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSidebar.Controls.Add(this.lvTemplateSelection);
            this.panelSidebar.Controls.Add(this.btnLoadJson);
            this.panelSidebar.Controls.Add(this.lLoad);
            this.panelSidebar.Controls.Add(this.lSave);
            this.panelSidebar.Controls.Add(this.btnSaveJson);
            this.panelSidebar.Controls.Add(this.btnLoad);
            this.panelSidebar.Controls.Add(this.btnSave);
            this.panelSidebar.Controls.Add(this.lState);
            this.panelSidebar.Controls.Add(this.lCoordinates);
            this.panelSidebar.Controls.Add(this.btnPaint);
            this.panelSidebar.Controls.Add(this.btnClear);
            this.panelSidebar.Controls.Add(this.btnNext);
            this.panelSidebar.Controls.Add(this.btnPause);
            this.panelSidebar.Location = new System.Drawing.Point(687, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(127, 683);
            this.panelSidebar.TabIndex = 1;
            // 
            // lvTemplateSelection
            // 
            this.lvTemplateSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTemplateSelection.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lvTemplateSelection.FullRowSelect = true;
            this.lvTemplateSelection.HideSelection = false;
            this.lvTemplateSelection.LargeImageList = this.imageList1;
            this.lvTemplateSelection.Location = new System.Drawing.Point(3, 319);
            this.lvTemplateSelection.Name = "lvTemplateSelection";
            this.lvTemplateSelection.Size = new System.Drawing.Size(120, 265);
            this.lvTemplateSelection.SmallImageList = this.imageList1;
            this.lvTemplateSelection.TabIndex = 2;
            this.lvTemplateSelection.UseCompatibleStateImageBehavior = false;
            this.lvTemplateSelection.DoubleClick += new System.EventHandler(this.Listview_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pixil-frame-0.png");
            this.imageList1.Images.SetKeyName(1, "Aim.png");
            this.imageList1.Images.SetKeyName(2, "SS.png");
            this.imageList1.Images.SetKeyName(3, "Slugger.png");
            this.imageList1.Images.SetKeyName(4, "GG.png");
            this.imageList1.Images.SetKeyName(5, "Carpet.png");
            this.imageList1.Images.SetKeyName(6, "Blackhole.png");
            this.imageList1.Images.SetKeyName(7, "Big.png");
            this.imageList1.Images.SetKeyName(8, "Small.png");
            this.imageList1.Images.SetKeyName(9, "Galaxy.png");
            this.imageList1.Images.SetKeyName(10, "Ladder.png");
            this.imageList1.Images.SetKeyName(11, "Conveyor.png");
            this.imageList1.Images.SetKeyName(12, "Rocket.png");
            this.imageList1.Images.SetKeyName(13, "Around.png");
            this.imageList1.Images.SetKeyName(14, "Wallbuilder.png");
            this.imageList1.Images.SetKeyName(15, "Galaxy.png");
            this.imageList1.Images.SetKeyName(16, "Spinner.png");
            this.imageList1.Images.SetKeyName(17, "Gol.png");
            // 
            // btnLoadJson
            // 
            this.btnLoadJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadJson.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadJson.Location = new System.Drawing.Point(64, 281);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(59, 32);
            this.btnLoadJson.TabIndex = 12;
            this.btnLoadJson.Text = "Json";
            this.btnLoadJson.UseVisualStyleBackColor = true;
            this.btnLoadJson.Click += new System.EventHandler(this.LoadButton_Click_Json);
            // 
            // lLoad
            // 
            this.lLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lLoad.AutoSize = true;
            this.lLoad.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLoad.Location = new System.Drawing.Point(3, 261);
            this.lLoad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLoad.Name = "lLoad";
            this.lLoad.Size = new System.Drawing.Size(74, 17);
            this.lLoad.TabIndex = 16;
            this.lLoad.Text = "Load from . . .";
            // 
            // lSave
            // 
            this.lSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lSave.AutoSize = true;
            this.lSave.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSave.Location = new System.Drawing.Point(3, 205);
            this.lSave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSave.Name = "lSave";
            this.lSave.Size = new System.Drawing.Size(61, 17);
            this.lSave.TabIndex = 15;
            this.lSave.Text = "Save As . . .";
            // 
            // btnSaveJson
            // 
            this.btnSaveJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveJson.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveJson.Location = new System.Drawing.Point(64, 222);
            this.btnSaveJson.Name = "btnSaveJson";
            this.btnSaveJson.Size = new System.Drawing.Size(59, 32);
            this.btnSaveJson.TabIndex = 14;
            this.btnSaveJson.Text = "Json";
            this.btnSaveJson.UseVisualStyleBackColor = true;
            this.btnSaveJson.Click += new System.EventHandler(this.SaveButton_Click_Json);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(3, 281);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(59, 32);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Text";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(59, 32);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Text";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // lState
            // 
            this.lState.AutoSize = true;
            this.lState.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lState.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lState.Location = new System.Drawing.Point(2, 141);
            this.lState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lState.Name = "lState";
            this.lState.Size = new System.Drawing.Size(40, 23);
            this.lState.TabIndex = 13;
            this.lState.Text = "???";
            // 
            // lCoordinates
            // 
            this.lCoordinates.AutoSize = true;
            this.lCoordinates.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lCoordinates.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCoordinates.Location = new System.Drawing.Point(2, 115);
            this.lCoordinates.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCoordinates.Name = "lCoordinates";
            this.lCoordinates.Size = new System.Drawing.Size(40, 23);
            this.lCoordinates.TabIndex = 12;
            this.lCoordinates.Text = "???";
            // 
            // btnPaint
            // 
            this.btnPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaint.AutoSize = true;
            this.btnPaint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPaint.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaint.Location = new System.Drawing.Point(4, 10);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(119, 27);
            this.btnPaint.TabIndex = 2;
            this.btnPaint.Text = "        Painting";
            this.btnPaint.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(3, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 32);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(3, 42);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 32);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.Next_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 683);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new System.Drawing.Size(306, 642);
            this.Name = "FormMain";
            this.Text = "Conway´s Game of Live";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_MainForm);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_MainForm);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_MainForm);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.CheckBox btnPaint;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lCoordinates;
        private System.Windows.Forms.Label lState;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveJson;
        private System.Windows.Forms.Label lSave;
        private System.Windows.Forms.Label lLoad;
        private System.Windows.Forms.Button btnLoadJson;
        private System.Windows.Forms.ListView lvTemplateSelection;
        private System.Windows.Forms.ImageList imageList1;
    }
}


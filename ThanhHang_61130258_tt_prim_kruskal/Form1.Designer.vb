<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnprim = New System.Windows.Forms.Button()
        Me.btnkruskal = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtAD = New System.Windows.Forms.TextBox()
        Me.txtAB = New System.Windows.Forms.TextBox()
        Me.txtAC = New System.Windows.Forms.TextBox()
        Me.txtBC = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btnmota = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsua = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(0, 0)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(133, 35)
        Me.Label23.TabIndex = 154
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(0, 0)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(133, 35)
        Me.Label22.TabIndex = 155
        '
        'btnprim
        '
        Me.btnprim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnprim.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnprim.Location = New System.Drawing.Point(724, 215)
        Me.btnprim.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnprim.Name = "btnprim"
        Me.btnprim.Size = New System.Drawing.Size(189, 125)
        Me.btnprim.TabIndex = 136
        Me.btnprim.Text = "PRIM"
        Me.btnprim.UseVisualStyleBackColor = True
        '
        'btnkruskal
        '
        Me.btnkruskal.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnkruskal.Location = New System.Drawing.Point(989, 215)
        Me.btnkruskal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnkruskal.Name = "btnkruskal"
        Me.btnkruskal.Size = New System.Drawing.Size(189, 125)
        Me.btnkruskal.TabIndex = 137
        Me.btnkruskal.Text = "KRUSKAL"
        Me.btnkruskal.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Bisque
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(41, 215)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(606, 441)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 143
        Me.PictureBox2.TabStop = False
        '
        'txtAD
        '
        Me.txtAD.Enabled = False
        Me.txtAD.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAD.Location = New System.Drawing.Point(138, 400)
        Me.txtAD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAD.Name = "txtAD"
        Me.txtAD.Size = New System.Drawing.Size(36, 34)
        Me.txtAD.TabIndex = 144
        Me.txtAD.Text = "7"
        Me.txtAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAB
        '
        Me.txtAB.Enabled = False
        Me.txtAB.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAB.Location = New System.Drawing.Point(350, 248)
        Me.txtAB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAB.Name = "txtAB"
        Me.txtAB.Size = New System.Drawing.Size(37, 34)
        Me.txtAB.TabIndex = 146
        Me.txtAB.Text = "5"
        Me.txtAB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAC
        '
        Me.txtAC.Enabled = False
        Me.txtAC.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAC.Location = New System.Drawing.Point(350, 382)
        Me.txtAC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAC.Multiline = True
        Me.txtAC.Name = "txtAC"
        Me.txtAC.Size = New System.Drawing.Size(37, 34)
        Me.txtAC.TabIndex = 147
        Me.txtAC.Text = "11"
        Me.txtAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBC
        '
        Me.txtBC.Enabled = False
        Me.txtBC.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtBC.Location = New System.Drawing.Point(534, 350)
        Me.txtBC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBC.Name = "txtBC"
        Me.txtBC.Size = New System.Drawing.Size(38, 34)
        Me.txtBC.TabIndex = 148
        Me.txtBC.Text = "9"
        Me.txtBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Bisque
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(41, 92)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1137, 61)
        Me.TextBox1.TabIndex = 149
        Me.TextBox1.Text = "THUẬT TOÁN PRIM VÀ KRUSKAL"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnthoat
        '
        Me.btnthoat.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnthoat.Location = New System.Drawing.Point(724, 531)
        Me.btnthoat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(189, 125)
        Me.btnthoat.TabIndex = 151
        Me.btnthoat.Text = "EXIT"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btnmota
        '
        Me.btnmota.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnmota.Location = New System.Drawing.Point(989, 531)
        Me.btnmota.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnmota.Name = "btnmota"
        Me.btnmota.Size = New System.Drawing.Size(189, 125)
        Me.btnmota.TabIndex = 153
        Me.btnmota.Text = "NEXT"
        Me.btnmota.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnxoa.Location = New System.Drawing.Point(989, 382)
        Me.btnxoa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(189, 125)
        Me.btnxoa.TabIndex = 152
        Me.btnxoa.Text = "DELETE"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 35)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 35)
        Me.Label2.TabIndex = 1
        '
        'btnsua
        '
        Me.btnsua.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnsua.Location = New System.Drawing.Point(724, 382)
        Me.btnsua.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(189, 125)
        Me.btnsua.TabIndex = 150
        Me.btnsua.Text = "UPDATE"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1241, 771)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnmota)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtBC)
        Me.Controls.Add(Me.txtAC)
        Me.Controls.Add(Me.txtAB)
        Me.Controls.Add(Me.txtAD)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnkruskal)
        Me.Controls.Add(Me.btnprim)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Thuật toán Prim và Kruskal - DEMO 1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents btnprim As Button
    Friend WithEvents btnkruskal As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtAD As TextBox
    Friend WithEvents txtAB As TextBox
    Friend WithEvents txtAC As TextBox
    Friend WithEvents txtBC As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnthoat As Button
    Friend WithEvents btnmota As Button
    Friend WithEvents btnxoa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsua As Button
End Class

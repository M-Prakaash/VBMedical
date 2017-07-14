<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.capture = New System.Windows.Forms.Button
        Me.Surveyor1editedDataSet = New WindowsApplication1.surveyor1editedDataSet
        Me.Copy_of_Surveytable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Copy_of_Surveytable1TableAdapter = New WindowsApplication1.surveyor1editedDataSetTableAdapters.Copy_of_Surveytable1TableAdapter
        Me.TableAdapterManager = New WindowsApplication1.surveyor1editedDataSetTableAdapters.TableAdapterManager
        Me.PicturePictureBox = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        CType(Me.Surveyor1editedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Copy_of_Surveytable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'capture
        '
        Me.capture.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.capture.Location = New System.Drawing.Point(339, 674)
        Me.capture.Name = "capture"
        Me.capture.Size = New System.Drawing.Size(169, 53)
        Me.capture.TabIndex = 0
        Me.capture.Text = "CLICK"
        Me.capture.UseCompatibleTextRendering = True
        Me.capture.UseVisualStyleBackColor = True
        '
        'Surveyor1editedDataSet
        '
        Me.Surveyor1editedDataSet.DataSetName = "surveyor1editedDataSet"
        Me.Surveyor1editedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Copy_of_Surveytable1BindingSource
        '
        Me.Copy_of_Surveytable1BindingSource.DataMember = "Copy of Surveytable1"
        Me.Copy_of_Surveytable1BindingSource.DataSource = Me.Surveyor1editedDataSet
        '
        'Copy_of_Surveytable1TableAdapter
        '
        Me.Copy_of_Surveytable1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Copy_of_Surveytable1TableAdapter = Me.Copy_of_Surveytable1TableAdapter
        Me.TableAdapterManager.Surveytable1TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.surveyor1editedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PicturePictureBox
        '
        Me.PicturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicturePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Copy_of_Surveytable1BindingSource, "picture", True))
        Me.PicturePictureBox.Location = New System.Drawing.Point(284, 158)
        Me.PicturePictureBox.Name = "PicturePictureBox"
        Me.PicturePictureBox.Size = New System.Drawing.Size(638, 447)
        Me.PicturePictureBox.TabIndex = 39
        Me.PicturePictureBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(844, 700)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 43)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "NEXT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(879, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 43)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "PREVIOUS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(82, 104)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(115, 29)
        Me.LinkLabel1.TabIndex = 42
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "CREATE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1076, 845)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PicturePictureBox)
        Me.Controls.Add(Me.capture)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Surveyor1editedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Copy_of_Surveytable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents capture As System.Windows.Forms.Button
    Friend WithEvents Surveyor1editedDataSet As WindowsApplication1.surveyor1editedDataSet
    Friend WithEvents Copy_of_Surveytable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Copy_of_Surveytable1TableAdapter As WindowsApplication1.surveyor1editedDataSetTableAdapters.Copy_of_Surveytable1TableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.surveyor1editedDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PicturePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class

Public Class Form_MainMenu
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Picture_MainMenu1.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Picture_SupMenu1_Click(sender As Object, e As EventArgs) Handles Picture_SupMenu1.Click
        Dim f As New LoginForm_Front
        f.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

        End Sub

        Private Sub MainMenu_Form_Click(sender As Object, e As EventArgs) Handles Me.Click

        End Sub

        Private Sub MainMenu_Form_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        End Sub

        Private Sub MainMenu_Form_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate

        End Sub

        Private Sub MainMenu_Form_Layout(sender As Object, e As LayoutEventArgs) Handles Me.Layout

        End Sub

        Private Sub MainMenu_Form_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Picture_SupMenu2_Click(sender As Object, e As EventArgs) Handles Picture_SupMenu2.Click

    End Sub

    Private Sub PictureBox1_Click_5(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Form_MainMenu_MenuComplete(sender As Object, e As EventArgs) Handles Me.MenuComplete

    End Sub
End Class

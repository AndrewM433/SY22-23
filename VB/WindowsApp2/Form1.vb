Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles conorbutton.Click
        displayPictureBox1.Image = conorpicturebox.Image
        namelabel.Text = "Conor Mcgregor"
        Heightlabel.Text = "5Ft,9"
        reachlabel.Text = "74inch"
        agelabel.Text = "34"
    End Sub

    Private Sub Heightlabel_Click(sender As Object, e As EventArgs) Handles Heightlabel.Click

    End Sub

    Private Sub Tonybutton_Click(sender As Object, e As EventArgs) Handles Tonybutton.Click
        displayPictureBox1.Image = tonypicturebox.Image
        namelabel.Text = "Tony Ferguson"
        Heightlabel.Text = "5Ft,11"
        reachlabel.Text = "76inch"
        agelabel.Text = "38"
    End Sub

    Private Sub khabibbutton_Click(sender As Object, e As EventArgs) Handles khabibbutton.Click
        displayPictureBox1.Image = khabibbox.Image
        namelabel.Text = "Khabib Nurmagomedov"
        Heightlabel.Text = "5Ft,10"
        reachlabel.Text = "73inch"
        agelabel.Text = "33"
    End Sub



    Private Sub dustinbutton_Click(sender As Object, e As EventArgs) Handles dustinbutton.Click
        displayPictureBox1.Image = dustinbox.Image
        namelabel.Text = "Dustin Poirier"
        Heightlabel.Text = "5Ft,9"
        reachlabel.Text = "74inch"
        agelabel.Text = "33"
    End Sub

    Private Sub charlesbutton_Click(sender As Object, e As EventArgs) Handles charlesbutton.Click
        displayPictureBox1.Image = charlesbox.Image
        namelabel.Text = "Charles Oliveira"
        Heightlabel.Text = "5Ft,11"
        reachlabel.Text = "76inch"
        agelabel.Text = "32"
    End Sub
End Class
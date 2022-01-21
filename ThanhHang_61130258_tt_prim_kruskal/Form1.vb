Public Class Form1
    Dim dscanh() As Integer
    Dim tong As Integer = 0
    Dim kq As String = ""
    Dim i, a, b, c As Integer
    Private Sub btnprim_Click(sender As Object, e As EventArgs) Handles btnprim.Click
        If txtAB.Text = "" Or txtAD.Text = "" Or txtBC.Text = "" Or txtAC.Text = "" Then
            MessageBox.Show("Không được để trống độ dài. Vui lòng nhập lại !", "Thông báo")
        Else
            Dim AD, AB, BC, AC As Single
            AD = Val(txtAD.Text)
            AB = Val(txtAB.Text)
            BC = Val(txtBC.Text)
            AC = Val(txtAC.Text)

            dscanh = {AD, AB, AC}
            a = dscanh(0)
            For i = 1 To dscanh.Length - 1
                If a > dscanh(i) Then
                    a = dscanh(i)
                End If
            Next
            If a = AD Then
                dscanh = {AB, AC}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AC Then
                    If AB > BC Then
                        c = BC
                        kq = "Cây khung nhỏ nhất là: AD - " & a & " - AC - " & b & " - BC - " & c
                    Else
                        c = AB
                        kq = "Cây khung nhỏ nhất là: AD - " & a & " - AC - " & b & " - AB - " & c
                    End If
                Else
                    b = AB
                    If AC > BC Then
                        c = BC
                        kq = "Cây khung nhỏ nhất là: AD - " & a & " - AB - " & b & " - BC - " & c
                    Else
                        c = AC
                        kq = "Cây khung nhỏ nhất là: AD - " & a & " - AB - " & b & " - AC - " & c
                    End If
                End If
            ElseIf a = AC Then
                dscanh = {AD, AB, BC}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AD Then
                    If AB > BC Then
                        c = BC
                        kq = "Cây khung nhỏ nhất là: AC - " & a & " ,AD - " & b & " ,BC - " & c
                    Else
                        c = AB
                        kq = "Cây khung nhỏ nhất là: AC - " & a & " , AD - " & b & ", AB - " & c
                    End If
                ElseIf b = AB Then
                    c = AD
                    kq = "Cây khung nhỏ nhất là: AC - " & a & ", AB - " & b & ", AD - " & c
                ElseIf b = BC Then
                    c = AD
                    kq = "Cây khung nhỏ nhất là: AC - " & a & ", BC - " & b & ", AD - " & c

                End If

            ElseIf a = AB Then
                dscanh = {AD, AC, BC}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AD Then

                    If AC > BC Then
                        c = BC
                        kq = "Cây khung nhỏ nhất là: AB - " & a & ", AD - " & b & ", BC - " & c
                    Else
                        c = AC
                        kq = "Cây khung nhỏ nhất là: AB - " & a & ", AD - " & b & ", AC - " & c
                    End If
                ElseIf b = AC Then
                    c = AD
                    kq = "Cây khung nhỏ nhất là: AB - " & a & ", AC - " & b & ", AD - " & c
                ElseIf b = BC Then
                    c = AD
                    kq = "Cây khung nhỏ nhất là: AB - " & a & ", BC - " & b & ", AD - " & c
                End If
            End If
            tong = a + b + c
            MessageBox.Show(kq & vbNewLine & "Tổng trọng số của đồ thị là: " & tong, "Prim")
        End If
    End Sub

    Private Sub btnkruskal_Click(sender As Object, e As EventArgs) Handles btnkruskal.Click
        If txtAB.Text = "" Or txtAD.Text = "" Or txtBC.Text = "" Or txtAC.Text = "" Then
            MessageBox.Show("Không được để trống độ dài. Vui lòng nhập lại !", "Thông báo")
        Else
            Dim AD, AB, BC, AC As Single
            AD = Val(txtAD.Text)
            AB = Val(txtAB.Text)
            BC = Val(txtBC.Text)
            AC = Val(txtAC.Text)
            dscanh = {AD, AB, AC, BC}
            a = dscanh(0)
            For i = 1 To dscanh.Length - 1
                If a > dscanh(i) Then
                    a = dscanh(i)
                End If
            Next
            If a = AD Then
                dscanh = {AB, AC, BC}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AB Then
                    dscanh = {AC, BC}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AC Then
                        kq = "Cây khung cần tìm là: AD - " & a & ", AB - " & b & ", AC - " & c
                    ElseIf c = BC Then
                        kq = "Cây khung cần tìm là: AD - " & a & ", AB - " & b & ", BC - " & c
                    End If
                ElseIf b = AC Then
                    dscanh = {AB, BC}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AB Then
                        kq = "Cây khung cần tìm là: AD - " & a & ", AC - " & b & ", AB - " & c
                    ElseIf c = BC Then
                        kq = "Cây khung cần tìm là: AD - " & a & ", AC - " & b & ", BC - " & c
                    End If
                ElseIf b = BC Then
                    dscanh = {AB, AC}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AC Then
                        kq = "Cây khung cần tìm là: AD - " & a & ", BC - " & b & ", AC - " & c
                    ElseIf c = AB Then
                        kq = "Cây khung cần tìm là: AD - " & a & ", BC - " & b & ", AB - " & c
                    End If
                End If
            ElseIf a = AB Then
                dscanh = {AD, AC, BC}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AD Then
                    dscanh = {AC, BC}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AC Then
                        kq = "Cây khung cần tìm là: AB - " & a & ", AD - " & b & ", AC - " & c

                    ElseIf c = BC Then
                        kq = "Cây khung cần tìm là: AB - " & a & ", AD - " & b & ", BC - " & c
                    End If
                ElseIf b = AC Then
                    c = AD
                    kq = "Cây khung cần tìm là: AB - " & a & ", AC - " & b & ", AD - " & c
                ElseIf b = BC Then
                    c = AD
                    kq = "Cây khung cần tìm là: AB - " & a & ", BC - " & b & ", AD - " & c
                End If

            ElseIf a = AC Then
                dscanh = {AD, AB, BC}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AD Then
                    dscanh = {AB, BC}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AB Then
                        kq = "Cây khung cần tìm là: AC - " & a & ", AD - " & b & ", AB - " & c

                    ElseIf c = BC Then
                        kq = "Cây khung cần tìm là: AC - " & a & ", AD - " & b & ", BC - " & c
                    End If
                ElseIf b = AB Then
                    c = AD
                    kq = "Cây khung cần tìm là: AC - " & a & ", AB - " & b & ", AD - " & c

                ElseIf b = BC Then
                    c = AD
                    kq = "Cây khung cần tìm là: AC - " & a & ", BC - " & b & ", AD - " & c

                End If
            ElseIf a = BC Then
                dscanh = {AD, AB, AC}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AD Then
                    dscanh = {AB, AB}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AB Then
                        kq = "Cây khung cần tìm là: BC - " & a & ", AD - " & b & ", AB - " & c

                    ElseIf c = AC Then
                        kq = "Cây khung cần tìm là: BC - " & a & ", AD - " & b & ", AC - " & c

                    End If
                ElseIf b = AB Then
                    c = AD
                    kq = "Cây khung cần tìm là: BC - " & a & ", AB - " & b & ", AD - " & c

                ElseIf b = AC Then
                    c = AD
                    kq = "Cây khung cần tìm là: BC - " & a & ", AC - " & b & ", AD - " & c
                End If
            End If
            tong = a + b + c
            MessageBox.Show(kq & vbNewLine & "Tổng trọng số của cây khung là: " & tong, "Kruskal")
        End If
    End Sub
    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        txtAB.Text = ""
        txtAC.Text = ""
        txtAD.Text = ""
        txtBC.Text = ""
        txtAB.Focus()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        txtAB.Enabled = True
        txtAC.Enabled = True
        txtAD.Enabled = True
        txtBC.Enabled = True
    End Sub
    Private Sub btnmota_Click(sender As Object, e As EventArgs) Handles btnmota.Click
        Dim form2 As Form2 = New Form2
        form2.Show()
    End Sub
    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class

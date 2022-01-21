Public Class form2
    Dim dscanh() As Integer
    Dim tong As Integer = 0
    Dim kq As String = ""
    Dim i, a, b, c, d As Integer
    Private Sub btnprim_Click(sender As Object, e As EventArgs) Handles btnprim.Click
        If txtAB.Text = "" Or txtAD.Text = "" Or txtBC.Text = "" Or txtAC.Text = "" Then
            MessageBox.Show("Không được để trống độ dài. Vui lòng nhập lại !", "Thông báo")
        Else
            Dim AD, AB, BC, AC, CE, BE As Single
            AD = Val(txtAD.Text)
            AB = Val(txtAB.Text)
            BC = Val(txtBC.Text)
            AC = Val(txtAC.Text)
            CE = Val(txtCE.Text)
            BE = Val(txtBE.Text)
            'B1 
            dscanh = {AD, AB, AC}
            a = dscanh(0)
            For i = 1 To dscanh.Length - 1
                If a > dscanh(i) Then
                    a = dscanh(i)
                End If
            Next
            'B2
            If a = AD Then
                dscanh = {AB, AC}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AC Then
                    dscanh = {AB, BC, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AB Then
                        dscanh = {CE, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung cần tìm là: AD - " & a & ", AC - " & b & ", AB - " & c & ", CE - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung cần tìm là: AD - " & a & ", AC - " & b & ", AB - " & c & ", BE - " & d
                        End If
                    ElseIf c = BC Then
                        dscanh = {CE, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung cần tìm là: AD - " & a & ", AC - " & b & ", BC - " & c & ", CE - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung cần tìm là: AD - " & a & ", AC - " & b & ", BC - " & c & ", BE - " & d
                        End If
                    ElseIf c = CE Then
                        dscanh = {AB, BC, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = AB Then
                            kq = "Cây khung cần tìm là: AD - " & a & ", AC - " & b & ", CE - " & c & ", AB - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung cần tìm là: AD - " & a & ", AC - " & b & ", CE - " & c & ", BC - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung cần tìm là: AD - " & a & ", AC - " & b & ", CE - " & c & ", BE - " & d
                        End If
                    End If
                ElseIf b = AB Then
                    dscanh = {AC, BC, BE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AC Then
                        dscanh = {BE, CE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = BE Then
                            kq = "Cây khung cần tìm là: AD - " & a & ", AB - " & b & ", AC - " & c & ", BE - " & d
                        ElseIf d = CE Then
                            kq = "Cây khung cần tìm là: AD - " & a & ", AB - " & b & ", AC - " & c & ", CE - " & d
                        End If
                    ElseIf c = BC Then
                        dscanh = {CE, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung cần tìm là: AD - " & a & ", AB - " & b & ", BC - " & c & ", CE - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung cần tìm là: AD - " & a & ", AB - " & b & ", BC - " & c & ", BE - " & d
                        End If
                    ElseIf c = BE Then
                        dscanh = {AB, BC, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = AC Then
                            kq = "Cây khung cần tìm là: AD - " & a & ", AB - " & b & ", BE - " & c & ", AC - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung cần tìm là: AD - " & a & ", AB - " & b & ", BE - " & c & ", BC - " & d
                        ElseIf d = CE Then
                            kq = "Cây khung cần tìm là: AD - " & a & ", AB - " & b & ", BE - " & c & ", CE - " & d
                        End If
                    End If
                End If
            ElseIf a = AC Then
                dscanh = {AB, AD, BC, CE}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AD Then
                    dscanh = {AB, BC, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AB Then
                        dscanh = {CE, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", AD - " & b & ", AB - " & c & ", CE - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", AD - " & b & ", AB - " & c & ", BE - " & d
                        End If
                    ElseIf c = BC Then
                        dscanh = {CE, BE, AB}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", AD - " & b & ", BC - " & c & ", CE - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", AD - " & b & ", BC - " & c & ", BE - " & d
                        ElseIf d = AB Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", AD - " & b & ", BC - " & c & ", AB - " & d
                        End If
                    ElseIf c = CE Then
                        dscanh = {AB, BC, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = AB Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", AD - " & b & ", CE - " & c & ", AB - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", AD - " & b & ", CE - " & c & ", BC - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", AD - " & b & ", CE - " & c & ", BE - " & d
                        End If
                    End If
                ElseIf b = AB Then
                    dscanh = {AD, CE, BE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = CE Then
                        d = AD
                        kq = "Cây khung cần tìm là: AC - " & a & ", AB - " & b & ", CE - " & c & ", AD - " & d
                    ElseIf c = BE Then
                        d = AD
                        kq = "Cây khung cần tìm là: AC - " & a & ", AB - " & b & ", BE - " & c & ", AD - " & d
                    ElseIf c = AD Then
                        dscanh = {BE, CE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = BE Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", AB - " & b & ", AD - " & c & ", BE - " & d
                        ElseIf d = CE Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", AB - " & b & ", AD - " & c & ", CE - " & d
                        End If
                    End If
                ElseIf b = BC Then
                    dscanh = {AD, CE, BE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = CE Then
                        d = AD
                        kq = "Cây khung cần tìm là: AC - " & a & ", BC - " & b & ", CE - " & c & ", AD - " & d
                    ElseIf c = BE Then
                        d = AD
                        kq = "Cây khung cần tìm là: AC - " & a & ", BC - " & b & ", BE - " & c & ", AD - " & d
                    ElseIf c = AD Then
                        dscanh = {BE, CE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = BE Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", BC - " & b & ", AD - " & c & ", BE - " & d
                        ElseIf d = CE Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", BC - " & b & ", AD - " & c & ", CE - " & d
                        End If
                    End If
                ElseIf b = CE Then
                    dscanh = {AD, AB, BE, BC}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        dscanh = {AB, BC, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = AB Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", CE - " & b & ", AD - " & c & ", AB - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", CE - " & b & ", AD - " & c & ", BC - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", CE - " & b & ", AD - " & c & ", BE - " & d
                        End If
                    ElseIf c = BC Then
                        d = AD
                        kq = "Cây khung cần tìm là: AC - " & a & ", CE - " & b & ", BC - " & c & ", AD - " & d
                    ElseIf c = BE Then
                        d = AD
                        kq = "Cây khung cần tìm là: AC - " & a & ", CE - " & b & ", BE - " & c & ", AD - " & d
                    ElseIf c = AB Then
                        dscanh = {AD, BC}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = AD Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", CE - " & b & ", AB - " & c & ", AD - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung cần tìm là: AC - " & a & ", CE - " & b & ", AB - " & c & ", BC - " & d
                        End If
                    End If
                End If

            ElseIf a = AB Then
                dscanh = {AD, AC, BC, BE}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AD Then
                    dscanh = {AC, BC, BE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AC Then
                        dscanh = {CE, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", AD - " & b & ", AC - " & c & ", CE - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", AD - " & b & ", AC - " & c & ", BE - " & d
                        End If
                    ElseIf c = BC Then
                        dscanh = {CE, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", AD - " & b & ", BC - " & c & ", CE - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", AD - " & b & ", BC - " & c & ", BE - " & d
                        End If
                    ElseIf c = BE Then
                        dscanh = {AC, BC, CE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = AC Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", AD - " & b & ", BE - " & c & ", AC - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", AD - " & b & ", BE - " & c & ", BC - " & d
                        ElseIf d = CE Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", AD - " & b & ", BE - " & c & ", CE - " & d
                        End If
                    End If
                ElseIf b = AC Then
                    dscanh = {AD, CE, BE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        dscanh = {CE, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", AC - " & b & ", AD - " & c & ", CE - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", AC - " & b & ", AD - " & c & ", BE - " & d
                        End If
                    ElseIf c = BE Then
                        dscanh = {CE, AD}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = AD Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", AC - " & b & ", BE - " & c & ", AD - " & d
                        ElseIf d = CE Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", AC - " & b & ", BE - " & c & ", CE - " & d
                        End If
                    ElseIf c = CE Then
                        d = AD
                        kq = "Cây khung cần tìm là: AB - " & a & ", AC - " & b & ", CE - " & c & ", AD - " & d
                    End If
                ElseIf b = BC Then
                    dscanh = {AD, CE, BE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        dscanh = {CE, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", BC - " & b & ", AD - " & c & ", CE - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", BC - " & b & ", AD - " & c & ", BE - " & d
                        End If
                    ElseIf c = CE Then
                        d = AD
                        kq = "Cây khung cần tìm là: AB - " & a & ", BC - " & b & ", CE - " & c & ", AD - " & d
                    ElseIf c = BE Then
                        d = AD
                        kq = "Cây khung cần tìm là: AB - " & a & ", BC - " & b & ", BE - " & c & ", AD - " & d
                    End If
                ElseIf b = BE Then
                    dscanh = {AD, AC, BC, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        dscanh = {AC, BC, CE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = AC Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", BE - " & b & ", AD - " & c & ", AC - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", BE - " & b & ", AD - " & c & ", BC - " & d
                        ElseIf d = CE Then
                            kq = "Cây khung cần tìm là: AB - " & a & ", BE - " & b & ", AD - " & c & ", CE - " & d
                        End If
                    ElseIf c = AC Then
                        d = AD
                        kq = "Cây khung cần tìm là: AB - " & a & ", BE - " & b & ", AC - " & c & ", AD - " & d
                    ElseIf c = BC Then
                        d = AD
                        kq = "Cây khung cần tìm là: AB - " & a & ", BE - " & b & ", BC - " & c & ", AD - " & d
                    ElseIf c = CE Then
                        d = AD
                        kq = "Cây khung cần tìm là: AB - " & a & ", BE - " & b & ", CE - " & c & ", AD - " & d
                    End If
                End If
            End If
            tong = a + b + c + d
            MessageBox.Show(kq & vbNewLine & "Tổng trọng số của đồ thị là: " & tong, "Prim")
        End If
    End Sub

    Private Sub btnkruskal_Click(sender As Object, e As EventArgs) Handles btnkruskal.Click
        If txtAB.Text = "" Or txtAD.Text = "" Or txtBC.Text = "" Or txtAC.Text = "" Then
            MessageBox.Show("Không được để trống độ dài. Vui lòng nhập lại !", "Thông báo")
        Else
            Dim AD, AB, BC, AC, CE, BE As Single
            AD = Val(txtAD.Text)
            AB = Val(txtAB.Text)
            BC = Val(txtBC.Text)
            AC = Val(txtAC.Text)
            CE = Val(txtCE.Text)
            BE = Val(txtBE.Text)
            'B1 
            dscanh = {AD, AB, AC, BC, BE, CE}
            a = dscanh(0)
            For i = 1 To dscanh.Length - 1
                If a > dscanh(i) Then
                    a = dscanh(i)
                End If
            Next
            'B2
            If a = AD Then
                dscanh = {AB, AC, BC, BE, CE}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AB Then
                    dscanh = {AC, BC, BE, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AC Then
                        If BE > CE Then
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AB - " & b & ", AC - " & c & ", CE - " & d
                        Else
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AB - " & b & ", AC - " & c & ", BE - " & d
                        End If
                    ElseIf c = BC Then
                        If BE > CE Then
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AB - " & b & ", BC - " & c & ", CE - " & d
                        Else
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AB - " & b & ", BC - " & c & ", BE - " & d
                        End If
                    ElseIf c = BE Then
                        dscanh = {AC, BC, CE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AB - " & b & ", BE - " & c & ", CE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AB - " & b & ", BE - " & c & ", BC - " & d
                        ElseIf d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AB - " & b & ", BE - " & c & ", AC - " & d
                        End If
                    ElseIf c = CE Then
                        dscanh = {AC, BE, BC}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = BE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AB - " & b & ", CE - " & c & ", BE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AB - " & b & ", CE - " & c & ", BC - " & d
                        ElseIf d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AB - " & b & ", CE - " & c & ", AC - " & d
                        End If
                    End If
                ElseIf b = AC Then
                    dscanh = {AB, BC, BE, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AB Then
                        dscanh = {BE, CE}
                        If BE > CE Then
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AC - " & b & ", AB - " & c & ", CE - " & d
                        Else
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AC - " & b & ", AB - " & c & ", BE - " & d
                        End If
                    ElseIf c = BC Then
                        If BE > CE Then
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AC - " & b & ", BC - " & c & ", CE - " & d
                        Else
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AC - " & b & ", BC - " & c & ", BE - " & d
                        End If
                    ElseIf c = BE Then
                        dscanh = {AB, BC, CE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AC - " & b & ", BE - " & c & ", CE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AC - " & b & ", BE - " & c & ", BC - " & d
                        ElseIf d = AB Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AC - " & b & ", BE - " & c & ", AB - " & d
                        End If
                    ElseIf c = CE Then
                        dscanh = {AB, BC, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = BE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AC - " & b & ", CE - " & c & ", BE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AC - " & b & ", CE - " & c & ", BC - " & d
                        ElseIf d = AB Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", AC - " & b & ", CE - " & c & ", AB - " & d
                        End If
                    End If
                ElseIf b = BE Then
                    dscanh = {AC, BC, AB, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AC Then
                        dscanh = {AB, BC, CE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BE - " & b & ", AC - " & c & ", CE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BE - " & b & ", AC - " & c & ", BC - " & d
                        ElseIf d = AB Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BE - " & b & ", AC - " & c & ", AB - " & d
                        End If
                    ElseIf c = BC Then
                        If AB > AC Then
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BE - " & b & ", BC - " & c & ", AC - " & d
                        Else
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BE - " & b & ", BC - " & c & ", AB - " & d
                        End If
                    ElseIf c = AB Then
                        dscanh = {AC, BC, CE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BE - " & b & ", AB - " & c & ", AC - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BE - " & b & ", AB - " & c & ", BC - " & d
                        ElseIf d = CE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BE - " & b & ", AB - " & c & ", CE - " & d
                        End If
                    ElseIf c = CE Then
                        If AB > AC Then
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BE - " & b & ", CE - " & c & ", AC - " & d
                        Else
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BE - " & b & ", CE - " & c & ", AB - " & d
                        End If
                    End If
                ElseIf b = BC Then
                    dscanh = {AC, AB, BE, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AC Then
                        dscanh = {CE, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If CE > BE Then
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BC - " & b & ", AC - " & c & ", BE - " & d
                        Else
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BC - " & b & ", AC - " & c & ", CE - " & d
                        End If
                    ElseIf c = AB Then
                        dscanh = {CE, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                    ElseIf c = BE Then
                        dscanh = {AC, AB}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If AB > AC Then
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BC - " & b & ", BE - " & c & ", AC - " & d
                        Else
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BC - " & b & ", BE - " & c & ", AB - " & d
                        End If
                    ElseIf c = CE Then
                        dscanh = {AC, AB}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If AB > AC Then
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BC - " & b & ", CE - " & c & ", AC - " & d
                        Else
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", BC - " & b & ", CE - " & c & ", AB - " & d
                        End If
                    End If
                ElseIf b = CE Then
                    dscanh = {AC, BC, BE, AB}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AC Then
                        dscanh = {BE, BC, AB}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = BE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", CE - " & b & ", AC - " & c & ", BE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", CE - " & b & ", AC - " & c & ", BC - " & d
                        ElseIf d = AB Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", CE - " & b & ", AC - " & c & ", AB - " & d
                        End If
                    ElseIf c = BC Then
                        dscanh = {AC, AB}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If AB > AC Then
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", CE - " & b & ", BC - " & c & ", AC - " & d
                        Else
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", CE - " & b & ", BC - " & c & ", AB - " & d
                        End If
                    ElseIf c = BE Then
                        dscanh = {AC, AB}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If AB > AC Then
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", CE - " & b & ", BE - " & c & ", AC - " & d
                        Else
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", CE - " & b & ", BE - " & c & ", AB - " & d
                        End If
                    ElseIf c = AB Then
                        dscanh = {AC, AB}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If AB > AC Then
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", CE - " & b & ", AB - " & c & ", AC - " & d
                        Else
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: AD - " & a & ", CE - " & b & ", AB - " & c & ", AB - " & d
                        End If
                    End If
                End If

            ElseIf a = AB Then
                dscanh = {AD, AC, BC, BE, CE}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AD Then
                    dscanh = {AC, BC, BE, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AC Then                        '
                        If BE > CE Then
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", AD - " & b & ", AC - " & c & ", CE - " & d
                        Else
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", AD - " & b & ", AC - " & c & ", BE - " & d
                        End If
                    ElseIf c = BC Then
                        If BE > CE Then
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", AD - " & b & ", BC - " & c & ", CE - " & d
                        Else
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", AD - " & b & ", BC - " & c & ", BE - " & d
                        End If
                    ElseIf c = BE Then
                        dscanh = {AC, BC, CE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", AD - " & b & ", BE - " & c & ", CE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", AD - " & b & ", BE - " & c & ", BC - " & d
                        ElseIf d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", AD - " & b & ", BE - " & c & ", AC - " & d
                        End If
                    ElseIf c = CE Then
                        dscanh = {AC, BE, BC}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = BE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", AD - " & b & ", CE - " & c & ", BE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", AD - " & b & ", CE - " & c & ", BC - " & d
                        ElseIf d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", AD - " & b & ", CE - " & c & ", AC - " & d
                        End If
                    End If
                ElseIf b = AC Then
                    dscanh = {AB, BE, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        dscanh = {BE, CE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If BE > CE Then
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", AC - " & b & ", AD - " & c & ", CE - " & d
                        Else
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", AC - " & b & ", AD - " & c & ", BE - " & d
                        End If
                    ElseIf c = BE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", AC - " & b & ", BE - " & c & ", AD - " & d
                    ElseIf c = CE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", AC - " & b & ", CE - " & c & ", AD - " & d
                    End If
                ElseIf b = BE Then
                    dscanh = {AD, BC, AC, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BE - " & b & ", AC - " & c & ", AD - " & d
                    ElseIf c = BC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BE - " & b & ", BC - " & c & ", AD - " & d
                    ElseIf c = AD Then
                        dscanh = {AC, BC, CE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BE - " & b & ", AD - " & c & ", AC - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BE - " & b & ", AD - " & c & ", BC - " & d
                        ElseIf d = CE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BE - " & b & ", AD - " & c & ", CE - " & d
                        End If
                    ElseIf c = CE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BE - " & b & ", CE - " & c & ", AD - " & d
                    End If
                ElseIf b = BC Then
                    dscanh = {AD, BE, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        If CE > BE Then
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BC - " & b & ", AD - " & c & ", BE - " & d
                        Else
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BC - " & b & ", AD - " & c & ", CE - " & d
                        End If
                    ElseIf c = BE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BC - " & b & ", BE - " & c & ", AD - " & d
                    ElseIf c = CE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BC - " & b & ", CE - " & c & ", AD - " & d
                    End If
                ElseIf b = CE Then
                    dscanh = {AC, BC, BE, AD}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        dscanh = {BE, BC, AC}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = BE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", CE - " & b & ", AD - " & c & ", BE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", CE - " & b & ", AD - " & c & ", BC - " & d
                        ElseIf d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", CE - " & b & ", AD - " & c & ", AC - " & d
                        End If
                    ElseIf c = BC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", CE - " & b & ", BC - " & c & ", AD - " & d
                    ElseIf c = BE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", CE - " & b & ", BE - " & c & ", AD - " & d
                    ElseIf c = AC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", CE - " & b & ", AC - " & c & ", AD - " & d
                    End If
                ElseIf b = BE Then
                    dscanh = {AC, BC, BE, AD}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        dscanh = {CE, BC, AC, AD}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BE - " & b & ", AD - " & c & ", CE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BE - " & c & ", AD - " & c & ", BC - " & d
                        ElseIf d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BE - " & b & ", AD - " & c & ", AC - " & d
                        End If
                    ElseIf c = BC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BE - " & b & ", BC - " & c & ", AD - " & d
                    ElseIf c = CE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BE - " & b & ", CE - " & c & ", AD - " & d
                    ElseIf c = AC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AB - " & a & ", BE - " & b & ", AC - " & c & ", AD - " & d
                    End If
                End If
            ElseIf a = AC Then
                dscanh = {AD, AB, BC, BE, CE}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AD Then
                    dscanh = {AB, BC, BE, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AB Then
                        If BE > CE Then
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", AD - " & b & ", AB - " & c & ", CE - " & d
                        Else
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", AD - " & b & ", AB - " & c & ", BE - " & d
                        End If
                    ElseIf c = BC Then
                        If BE > CE Then
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", AD - " & b & ", BC - " & c & ", CE - " & d
                        Else
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", AD - " & b & ", BC - " & c & ", BE - " & d
                        End If
                    ElseIf c = CE Then
                        dscanh = {AC, BC, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = BE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", AD - " & b & ", CE - " & c & ", BE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", AD - " & b & ", CE - " & c & ", BC - " & d
                        ElseIf d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", AD - " & b & ", CE - " & c & ", AC - " & d
                        End If
                    ElseIf c = BE Then
                        dscanh = {AC, BC, CE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", AD - " & b & ", BE - " & c & ", CE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", AD - " & b & ", BE - " & c & ", BC - " & d
                        ElseIf d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", AD - " & b & ", BE - " & c & ", AC - " & d
                        End If
                    End If
                ElseIf b = AB Then
                    dscanh = {AD, BE, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        If BE > CE Then
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", AB - " & b & ", AD - " & c & ", CE - " & d
                        Else
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", AB - " & b & ", AD - " & c & ", BE - " & d
                        End If
                    ElseIf c = BE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", AB - " & b & ", BE - " & c & ", AD - " & d
                    ElseIf c = CE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", AB - " & b & ", CE - " & c & ", AD - " & d
                    End If
                ElseIf b = BC Then
                    dscanh = {AD, BE, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        If BE > CE Then
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", BC - " & b & ", AD - " & c & ", CE - " & d
                        Else
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", BC - " & b & ", AD - " & c & ", BE - " & d
                        End If
                    ElseIf c = BE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", BC - " & b & ", BE - " & c & ", AD - " & d
                    ElseIf c = CE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", BC - " & b & ", CE - " & c & ", AD - " & d
                    End If
                ElseIf b = CE Then
                    dscanh = {AD, AB, BE, BC}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        dscanh = {AB, BE, BC}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", CE - " & b & ", AD - " & c & ", CE - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", CE - " & b & ", AD - " & c & ", BE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", CE - " & b & ", AD - " & c & ", BC - " & d
                        End If
                    ElseIf c = BE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", CE - " & b & ", BE - " & c & ", AD - " & d
                    ElseIf c = BC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", CE - " & b & ", BC - " & c & ", AD - " & d
                    ElseIf c = AB Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", CE - " & b & ", AB - " & c & ", AD - " & d
                    End If
                ElseIf b = BE Then
                    dscanh = {AD, AB, BC, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        dscanh = {AB, CE, BC}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = CE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", BE - " & b & ", AD - " & c & ", CE - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", BE - " & b & ", AD - " & c & ", BE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", BE - " & b & ", AD - " & c & ", BC - " & d
                        End If
                    ElseIf c = AB Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", BE - " & b & ", AB - " & c & ", AD - " & d
                    ElseIf c = BC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", BE - " & b & ", BC - " & c & ", AD - " & d
                    ElseIf c = CE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: AC - " & a & ", BE - " & b & ", CE - " & c & ", AD - " & d
                    End If
                End If

            ElseIf a = CE Then
                dscanh = {AD, AB, BC, AC}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AD Then
                    dscanh = {AB, BC, BE, AC}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AB Then
                        dscanh = {BC, BE, AC}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AD - " & b & ", AB - " & c & ", BC - " & d
                        ElseIf d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AD - " & b & ", AB - " & c & ", AC - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AD - " & b & ", AB - " & c & ", BE - " & d
                        End If
                    ElseIf c = BC Then
                        dscanh = {AB, BE, AC}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = AB Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AD - " & b & ", BC - " & c & ", AB - " & d
                        ElseIf d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AD - " & b & ", BC - " & c & ", AC - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AD - " & b & ", BC - " & c & ", BE - " & d
                        End If
                    ElseIf c = BE Then
                        If AC > AB Then
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AD - " & b & ", BE - " & c & ", AB - " & d
                        Else
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AD - " & b & ", BE - " & c & ", AC - " & d
                        End If
                    ElseIf c = AC Then
                        dscanh = {AB, BC, BE}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = AB Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AD - " & b & ", AC - " & c & ", AB - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AD - " & b & ", AC - " & c & ", BC - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AD - " & b & ", AC - " & c & ", BE - " & d
                        End If
                    End If
                ElseIf b = AB Then
                    dscanh = {AD, AC, BC, BE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        dscanh = {BC, BE, AC}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AB - " & b & ", AD - " & c & ", BC - " & d
                        ElseIf d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AB - " & b & ", AD - " & c & ", AC - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AB - " & b & ", AD - " & c & ", BE - " & d
                        End If
                    ElseIf c = BE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AB - " & b & ", BE - " & c & ", AD - " & d
                    ElseIf c = AC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AB - " & b & ", AC - " & c & ", AD - " & d
                    ElseIf c = BC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AB - " & b & ", BC - " & c & ", AD - " & d
                    End If
                ElseIf b = BC Then
                    dscanh = {AD, AC, AB}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        If AC > AB Then
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", BC - " & b & ", AD - " & c & ", AB - " & d
                        Else
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", BC - " & b & ", AD - " & c & ", AC - " & d
                        End If
                    ElseIf c = AC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", BC - " & b & ", AC - " & c & ", AD - " & d
                    ElseIf c = AB Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", BC - " & b & ", AB - " & c & ", AD - " & d
                    End If
                ElseIf b = AC Then
                    dscanh = {AD, AB, BE, BC}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        dscanh = {AB, BE, BC}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = AB Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AC - " & b & ", AD - " & c & ", AB - " & d
                        ElseIf d = BE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AC - " & b & ", AD - " & c & ", BE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AC - " & b & ", AD - " & c & ", BC - " & d
                        End If
                    ElseIf c = BE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AC - " & b & ", BE - " & c & ", AD - " & d
                    ElseIf c = BC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AC - " & b & ", BC - " & c & ", AD - " & d
                    ElseIf c = AB Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: CE - " & a & ", AC - " & b & ", AB - " & c & ", AD - " & d
                    End If
                End If
            ElseIf a = BE Then
                dscanh = {AD, AB, BC, AC, CE}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AD Then
                    dscanh = {AB, BC, CE, AC}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AB Then
                        dscanh = {BC, CE, AC}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AD - " & b & ", AB - " & c & ", BC - " & d
                        ElseIf d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AD - " & b & ", AB - " & c & ", AC - " & d
                        ElseIf d = CE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AD - " & b & ", AB - " & c & ", CE - " & d
                        End If
                    ElseIf c = AC Then
                        dscanh = {BC, CE, AB}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AD - " & b & ", AC - " & c & ", BC - " & d
                        ElseIf d = AB Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AD - " & b & ", AC - " & c & ", AB - " & d
                        ElseIf d = CE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AD - " & b & ", AC - " & c & ", CE - " & d
                        End If
                    ElseIf c = BC Then

                        If AC > AB Then
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AD - " & b & ", BC - " & c & ", AB - " & d
                        Else
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AD - " & b & ", BC - " & c & ", AC - " & d
                        End If
                    ElseIf c = CE Then

                        If AC > AB Then
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AD - " & b & ", CE - " & c & ", AB - " & d
                        Else
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AD - " & b & ", CE - " & c & ", AC - " & d
                        End If
                    End If
                ElseIf b = AC Then
                    dscanh = {BC, CE, AB, AD}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = BC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AC - " & b & ", BC - " & c & ", AD - " & d
                    ElseIf c = CE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AC - " & b & ", CE - " & c & ", AD - " & d
                    ElseIf c = AB Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AC - " & b & ", AB - " & c & ", AD - " & d
                    ElseIf c = AD Then
                        dscanh = {BC, CE, AB}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AC - " & b & ", AD - " & c & ", BC - " & d
                        ElseIf d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AC - " & b & ", AD - " & c & ", AC - " & d
                        ElseIf d = CE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AC - " & b & ", AD - " & c & ", CE - " & d
                        End If
                    End If
                ElseIf b = AB Then
                    dscanh = {BC, BE, AC, AD}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = BC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AB - " & b & ", BC - " & c & ", AD - " & d
                    ElseIf c = BE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AB - " & b & ", BE - " & c & ", AD - " & d
                    ElseIf c = AC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AB - " & b & ", AC - " & c & ", AD - " & d
                    ElseIf c = AD Then
                        dscanh = {BC, CE, AC}
                        d = dscanh(0)
                        For i = 1 To dscanh.Length - 1
                            If d > dscanh(i) Then
                                d = dscanh(i)
                            End If
                        Next
                        If d = AC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AB - " & b & ", AD - " & c & ", AC - " & d
                        ElseIf d = CE Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AB - " & b & ", AD - " & c & ", CE - " & d
                        ElseIf d = BC Then
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", AB - " & b & ", AD - " & c & ", BC - " & d
                        End If
                    End If
                ElseIf b = CE Then
                    dscanh = {AB, AC, AD}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AB Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", CE - " & b & ", AB - " & c & ", AD - " & d
                    ElseIf c = AC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", CE - " & b & ", AC - " & c & ", AD - " & d
                    ElseIf c = AD Then

                        If AC > AB Then
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", CE - " & b & ", AD - " & c & ", AB - " & d
                        Else
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: BE - " & a & ", CE - " & b & ", AD - " & c & ", AC - " & d
                        End If
                    End If
                End If
            ElseIf a = BC Then
                dscanh = {AD, AB, AC, BE, CE}
                b = dscanh(0)
                For i = 1 To dscanh.Length - 1
                    If b > dscanh(i) Then
                        b = dscanh(i)
                    End If
                Next
                If b = AD Then
                    dscanh = {AC, AB, BE, CE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AC Then
                        If CE > BE Then
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AD - " & b & ", AC - " & c & ", BE - " & d
                        Else
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AD - " & b & ", AC - " & c & ", CE - " & d
                        End If
                    ElseIf c = AB Then

                        If CE > BE Then
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AD - " & b & ", AB - " & c & ", BE - " & d
                        Else
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AD - " & b & ", AB - " & c & ", CE - " & d
                        End If
                    ElseIf c = BE Then

                        If AC > AB Then
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AD - " & b & ", BE - " & c & ", AB - " & d
                        Else
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AD - " & b & ", BE - " & c & ", AC - " & d
                        End If
                    ElseIf c = CE Then

                        If AC > AB Then
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AD - " & b & ", CE - " & c & ", AB - " & d
                        Else
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AD - " & b & ", CE - " & c & ", AC - " & d
                        End If
                    End If
                ElseIf b = AB Then
                    dscanh = {AD, CE, BE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        If CE > BE Then
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AB - " & b & ", AD - " & c & ", BE - " & d
                        Else
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AB - " & b & ", AD - " & c & ", CE - " & d
                        End If
                    ElseIf c = CE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AB - " & b & ", CE - " & c & ", AD - " & d
                    ElseIf c = BE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AB - " & b & ", BE - " & c & ", AD - " & d
                    End If
                ElseIf b = AC Then
                    dscanh = {AD, CE, BE}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        If CE > BE Then
                            d = BE
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AC - " & b & ", AD - " & c & ", BE - " & d
                        Else
                            d = CE
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AC - " & b & ", AD - " & c & ", CE - " & d
                        End If
                    ElseIf c = CE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AC - " & b & ", CE - " & c & ", AD - " & d
                    ElseIf c = BE Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", AC - " & b & ", BE - " & c & ", AD - " & d
                    End If
                ElseIf b = BE Then
                    dscanh = {AD, AC, AB}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        If AC > AB Then
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", BE - " & b & ", AD - " & c & ", AB - " & d
                        Else
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", BE - " & b & ", AD - " & c & ", AC - " & d
                        End If
                    ElseIf c = AC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", BE - " & b & ", AC - " & c & ", AD - " & d
                    ElseIf c = AB Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", BE - " & b & ", AB - " & c & ", AD - " & d
                    End If
                ElseIf b = CE Then
                    dscanh = {AD, AC, AB}
                    c = dscanh(0)
                    For i = 1 To dscanh.Length - 1
                        If c > dscanh(i) Then
                            c = dscanh(i)
                        End If
                    Next
                    If c = AD Then
                        If AC > AB Then
                            d = AB
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", CE - " & b & ", AD - " & c & ", AB - " & d
                        Else
                            d = AC
                            kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", CE - " & b & ", AD - " & c & ", AC - " & d
                        End If
                    ElseIf c = AC Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", CE - " & b & ", AC - " & c & ", AD - " & d
                    ElseIf c = AB Then
                        d = AD
                        kq = "Cây khung nhỏ nhất của đồ thị là: BC - " & a & ", CE - " & b & ", AB - " & c & ", AD - " & d
                    End If
                End If
            End If
            tong = a + b + c + d
            MessageBox.Show(kq & vbNewLine & "Tổng trọng số của cây khung là: " & tong, "Kruskal")
        End If
    End Sub
    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        txtAB.Text = ""
        txtAC.Text = ""
        txtAD.Text = ""
        txtBC.Text = ""
        txtCE.Text = ""
        txtBE.Text = ""
        txtAB.Focus()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        txtAB.Enabled = True
        txtAC.Enabled = True
        txtAD.Enabled = True
        txtBC.Enabled = True
        txtCE.Enabled = True
        txtBE.Enabled = True
    End Sub
    Private Sub btnmota_Click(sender As Object, e As EventArgs) Handles btnmota.Click
        Dim form1 As Form1 = New Form1
        form1.Show()
    End Sub
    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class

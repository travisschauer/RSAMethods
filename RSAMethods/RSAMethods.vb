'RSA Methods
'By Travis Schauer
'4/06/2021
'Senior Capstone
'This program demonstartes ecnryption/decryption using RSA 

Imports System.Numerics

Public Class MainForm

    Function isPrime(inInteger As Integer) As Boolean
        'Anything less than 2 is not prime
        If inInteger < 2 Then
            Return False
        End If

        'check if number has any divsors other than itself and 1
        For d As Integer = 2 To Math.Sqrt(inInteger)
            If inInteger Mod d = 0 Then
                Return False
            End If
        Next

        'not a prime
        Return True
    End Function

    Function GCDCalculate(a As Integer, b As Integer) As Integer
        'Source: programmingalgorithms.com
        If a = 0 Then
            Return b
        End If

        While b <> 0
            If a > b Then
                a -= b
            Else
                b -= a
            End If
        End While

        Return a
    End Function

    Function LCMCalculate(a As Integer, b As Integer) As Integer
        'Source: programmingalgorithms.com
        Return (a * b) \ GCDCalculate(a, b)
    End Function

    Function InverseModCalculate(a As Integer, n As Integer) As Integer
        Dim t, nt, r, nr, q, tmp As Long

        'intilaize parameters
        If n < 0 Then
            n = -n
        End If
        If a < 0 Then
            a = n - ((-a) Mod n)
        End If
        t = 0
        nt = 1
        r = n
        nr = a

        'lets calculate some stuff
        Do While nr <> 0
            q = r \ nr
            tmp = t
            t = nt
            nt = tmp - q * nt
            tmp = r
            r = nr
            nr = tmp - q * nr
        Loop

        'determine what we have
        If r > 1 Then
            MessageBox.Show("Error in Inverse Calculation", "Computational Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return 0
        Else
            If t < 0 Then
                t += n
            End If

            Return t
        End If
    End Function

    Function eCalculate(pInteger As Integer, qInteger As Integer) As Integer
        'this function calculates a random e
        Dim eList As ArrayList = New ArrayList()
        Dim LCMInteger, eInteger As Integer

        'calcualte lcm of p-1 and q-1
        LCMInteger = LCMCalculate(pInteger - 1, qInteger - 1)
        eInteger = 2

        'determine a list of coprimes
        While eInteger < LCMInteger
            If GCDCalculate(eInteger, LCMInteger) = 1 Then
                eList.Add(eInteger)
                eInteger += 1
            Else
                eInteger += 1
            End If
        End While

        'choose random index from list
        Return eList(New Random().Next(0, eList.Count - 1))
    End Function

    Function Encrypt(ExponentInteger As Integer, eInteger As Integer, nInteger As Integer) As Integer
        'create a Byte Array for the exponentiation
        Dim ExponentByteList As Byte() = BitConverter.GetBytes(ExponentInteger)

        'create a BigInteger using ByteList
        Dim ExponentBigInt = New BigInteger(ExponentByteList)
        Dim StaticExpBigInt = New BigInteger(ExponentByteList)

        'calculate ExponentInteger ^ eInteger
        For j As Integer = 1 To eInteger - 1
            ExponentBigInt *= StaticExpBigInt
        Next

        'do mod operation
        Dim ModInteger As Integer = ExponentBigInt Mod nInteger

        Return ModInteger
    End Function

    Function Decrypt(EncryptedInteger As Integer, dInteger As Integer, nInteger As Integer) As Integer
        'create byte array
        Dim EncryptedByteList As Byte() = BitConverter.GetBytes(EncryptedInteger)

        'create BigInts
        Dim EncryptedBigInteger = New BigInteger(EncryptedByteList)
        Dim StaticEncryptedBigInteger = New BigInteger(EncryptedByteList)

        'calculate EncryptedInteger ^ dInteger
        For i As Integer = 1 To dInteger - 1
            EncryptedBigInteger *= StaticEncryptedBigInteger
        Next

        'do mod operation
        Dim ModInteger As Integer = EncryptedBigInteger Mod nInteger

        Return ModInteger
    End Function

    Private Sub KeyCalculateButton_Click(sender As Object, e As EventArgs) Handles KeyCalculateButton.Click
        Dim pInteger, qInteger, nInteger, eInteger, dInteger As Integer

        Try
            'parse input
            pInteger = Integer.Parse(pKeyTextBox.Text)
            qInteger = Integer.Parse(qKeyTextBox.Text)

            'check if prime
            If isPrime(pInteger) = False Then
                'display error
                MessageBox.Show("p is not a prime number", "Data Entry Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

                'reset cursor
                pKeyTextBox.Focus()
                pKeyTextBox.SelectAll()

                Exit Try
            ElseIf isPrime(qInteger) = False Then
                'display error
                MessageBox.Show("q is not a prime number", "Data Entry Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

                'reset cursor
                pKeyTextBox.Focus()
                pKeyTextBox.SelectAll()

                Exit Try
            End If

            'calculate d, n, and e
            nInteger = pInteger * qInteger
            eInteger = eCalculate(pInteger, qInteger) 'calcuates a random e value
            dInteger = InverseModCalculate(eInteger, (pInteger - 1) * (qInteger - 1))

            'update Key Generator
            PrivateKeyTextBox.Text = dInteger.ToString()
            PublicKeyTextBox.Text = "(" & nInteger.ToString() & "," & eInteger.ToString() & ")"

            'update the rest of the form
            nEncryptTextBox.Text = nInteger.ToString()
            nDecryptTextBox.Text = nInteger.ToString()
            eEncryptTextBox.Text = eInteger.ToString()
            eDecryptTextBox.Text = eInteger.ToString()
            dDecryptTextBox.Text = dInteger.ToString()
        Catch PrimeParseException As FormatException
            'parse failed
            MessageBox.Show("Input must be an integer", "Data Entry Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'reset cursor
            pKeyTextBox.Focus()
            pKeyTextBox.SelectAll()
        End Try
    End Sub

    Private Sub EncryptButton_Click(sender As Object, e As EventArgs) Handles EncryptButton.Click
        Dim PlaintextString, IntegerString As String
        Dim nInteger, eInteger As Integer
        Dim InputCharList As New ArrayList
        Dim IntegerList As New ArrayList

        Try
            'get data from inputs
            nInteger = Integer.Parse(nEncryptTextBox.Text)
            eInteger = Integer.Parse(eEncryptTextBox.Text)
            PlaintextString = MessageEncryptTextBox.Text

            'add string to input list
            InputCharList.AddRange(PlaintextString.ToUpper.ToArray)

            'add bytes to integer list
            For Each c As Char In InputCharList
                IntegerList.Add(Convert.ToByte(c))
            Next

            'output infromation
            IntegerString = String.Concat(IntegerList.ToArray)
            IntegerConvListBox.Items.Add(IntegerString)

            'encrypt
            For i As Integer = 0 To IntegerList.Count() - 1
                'call function and add to list
                IntegerList(i) = Encrypt(IntegerList(i), eInteger, nInteger)
            Next

            'output information
            For i As Integer = 0 To IntegerList.Count() - 1
                EncrpytMsgListBox.Items.Add(IntegerList(i).ToString)
            Next

            'reset cursor
            MessageEncryptTextBox.Focus()
            MessageEncryptTextBox.SelectAll()
        Catch IntegerParseException As FormatException
            'parse failed
            MessageBox.Show("Input must be an integer", "Data Entry Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'reset cursor
            nEncryptTextBox.Focus()
            nEncryptTextBox.SelectAll()
        End Try
    End Sub

    Private Sub DecryptButton_Click(sender As Object, e As EventArgs) Handles DecryptButton.Click
        Dim nInteger, eInteger, dInteger, EncryptedInteger, DecryptedInteger As Integer
        Dim IntegerList As New ArrayList

        Try
            'get data from inputs
            nInteger = Integer.Parse(nDecryptTextBox.Text)
            eInteger = Integer.Parse(eDecryptTextBox.Text)
            dInteger = Integer.Parse(dDecryptTextBox.Text)
            EncryptedInteger = Integer.Parse(MessageDecryptTextBox.Text)

            'decrypt string
            DecryptedInteger = Decrypt(EncryptedInteger, dInteger, nInteger)

            'output
            DecryptIntListBox.Items.Add(DecryptedInteger)
            DecryptMsgListBox.Items.Add(Chr(DecryptedInteger))

            'reset cursor
            MessageDecryptTextBox.Focus()
            MessageDecryptTextBox.SelectAll()
        Catch IntegerParseException As FormatException
            'parse failed
            MessageBox.Show("Input must be an integer", "Data Entry Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'reset cursor
            nDecryptTextBox.Focus()
            nDecryptTextBox.SelectAll()
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'clear text boxes
        pKeyTextBox.Clear()
        qKeyTextBox.Clear()
        PrivateKeyTextBox.Clear()
        PublicKeyTextBox.Clear()
        nEncryptTextBox.Clear()
        eEncryptTextBox.Clear()
        MessageEncryptTextBox.Clear()
        nDecryptTextBox.Clear()
        eDecryptTextBox.Clear()
        dDecryptTextBox.Clear()
        MessageDecryptTextBox.Clear()

        'clear list boxes
        IntegerConvListBox.Items.Clear()
        EncrpytMsgListBox.Items.Clear()
        DecryptMsgListBox.Items.Clear()
        DecryptIntListBox.Items.Clear()
    End Sub
End Class
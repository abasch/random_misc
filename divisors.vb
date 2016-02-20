'  Counter
Function divCtr(n As Long) As Long

    Dim divisor As Long
    Dim ctr As Long
    
    For divisor = 1 To n
        If n Mod divisor = 0 Then
            ctr = ctr + 1
        End If
    Next divisor
    
    divCtr = ctr
    
End Function

' Is Number Prime
Function isPrime(n As Long) As Boolean
    isPrime = (divCtr(n) = 2)
End Function

Sub isPrime()
    Debug.Print isPrime(999999999)
End Sub

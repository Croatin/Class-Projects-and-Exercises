Public Class Form1

    Sub TurnLightOn()
        picLightOn.Visible = True
        picLightOff.Visible -False

        lblLightState.Text = "ON"
    End Sub

    Sub TurnLightOff()
        picLightOff.Visible = True
        picLightOn.Visible = False
        lblLightState.Text = "OFF"
    End Sub

    btnpart
    ' if picLightOn.Visible = true then 
    'turn light off()
    'else
    ' turnLightOn()
    'end if
    
End Class

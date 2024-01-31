# 0207131417_Murmelbahn
SPIELPRINZIP <br>
<br>
Diese 3D Murmelbahn ist wie folgt aufgebaut: Die Murmelbahn streckt sich durch einen Raum oder über einen Tisch. Es sind Start- und Endpunkt sowie Checkpoints definiert. <br>
<br>
Der Spieler in VR baut die Murmelbahn, um die Murmel bis ans Ziel zu bringen. Er ist jedoch an den Spieler vor dem Pepper’s Ghost angewiesen, da dieser ihm die verschiedenen Bauteile mithilfe des MakeyMakey auswählt.
Der Spieler vor dem Peppers Ghost kann den Bauteilen außerdem Speed-Boosts oder Slow-	Effect geben, welche sich auf die Murmel auswirken. <br>
<br>
Die beiden Spieler haben am Anfang ca. 30 Sekunden Zeit, bevor die Kugel das erste Mal rollt. Wenn die Kugel auf den Boden fällt, gibt es dafür einen Punkteabzug, die Kugel erscheint wieder am Anfang der Murmelbahn und rollt nach ca. 10 weiteren Sekunden erneut los.
Somit ist bei diesem Spiel Schnelligkeit, räumliches Denken und Kommunikation gefragt. <br>
<br>
<br>
<br>
STAND ZUM ZEITPUNKT DER ÜBERGABE <br>
<br>
- MakeyMakey implementiert:
  - setzt Prefabs zu den 4 Bauteilen (mit tags versehen) voraus
  - spricht Tasten "Up, Down, Left, Right" an, welche die verschiedenen Bauteile auswählen:
    - Keine mehrfachauswahl möglich
    - Prefabs von Bauteilen werden instanziert
  - spricht weiters die Tasten "Space, MouseLeft" an, mit welchen man die Speed-Changes steuert:
    - Wert "-1" bedeutet eine Verlangsamung der Murmel
    - Wert "0" bedeutet keine Änderung der Geschindigkeit
    - Wert "1" bedeutet eine Beschleunigung der Murmel
    - "Space" und "MouseLeft" addieren bzw. subtrahieren zum bzw. vom derzeitigen Wert jeweils 1
  - setzt Tags "buidlingPart1", "buidlingPart2", "buildingPart3", "buildingPart4" voraus; "buidlingPart0" NICHT vergeben
  - greift auf ChangeSpeedScript.speedChange zu

- ChangeSpeedScript:
  - als Component auf jedes Bauteil anhängen
  - Bauteile benötigen Trigger-Bereich
  - Murmel benötigt Rigidbody und tag "marble"
  - variable "speedChange" verdoppelt oder halbiert Geschwindigkeit der Murmel in Rollrichtung

- VR implementiert:
  -Die Scripts für die META Quest und Oculus sind drinnen
  -muss noch ausprobieren mit einer VR Brille

- ObjectSnapper Script:
  -momentan werden die Bauteile noch mit Leertaste gesnapt - für finale Version mit Handgrab.
  -Bauteile werden in 45° Winkel gesnapt.

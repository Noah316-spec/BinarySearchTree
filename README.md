# Binärer Suchbaum in C#

Dieses Programm implementiert einen binären Suchbaum in C#. Es besteht aus zwei Hauptklassen: `Node` und `BinarySearchTree`.
![image](https://github.com/Noah316-spec/BinarySearchTree/assets/106232024/d3a4b30c-410f-42ae-a8cf-3465549c8840)

## Klasse Node

Die `Node`-Klasse repräsentiert einen Knoten im binären Suchbaum. Jeder Knoten hat drei Eigenschaften:

- `data`: Der Wert, den der Knoten speichert. In diesem Fall handelt es sich um eine Ganzzahl.
- `leftChild`: Der linke Kindknoten des aktuellen Knotens. Alle Werte, die kleiner als der aktuelle Knoten sind, werden links eingefügt.
- `rightChild`: Der rechte Kindknoten des aktuellen Knotens. Alle Werte, die größer als der aktuelle Knoten sind, werden rechts eingefügt.

## Klasse BinarySearchTree

Die `BinarySearchTree`-Klasse implementiert die Funktionalitäten des binären Suchbaums. Sie hat eine Eigenschaft und drei Methoden:

- `root`: Der Wurzelknoten des Baums.

### Methode Insert

Die `Insert`-Methode fügt einen neuen Knoten in den Baum ein. Sie nimmt zwei Parameter: `index`, der den einzufügenden Wert darstellt, und `node`, der den einzufügenden Knoten darstellt.


### Methode Search

Die `Search`-Methode sucht einen bestimmten Wert im Baum. Sie gibt `true` zurück, wenn der Wert gefunden wird, sonst `false`.

### Methode InOrderTraversal

Die `InOrderTraversal`-Methode durchläuft den Baum in aufsteigender Reihenfolge und gibt die Werte aus. Sie nimmt einen `node` als Parameter, der den Knoten darstellt, von dem aus der Durchlauf beginnt.

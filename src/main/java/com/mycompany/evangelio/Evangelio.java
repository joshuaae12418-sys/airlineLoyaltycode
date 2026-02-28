package NewActivity;
import javax.swing.*;
import java.io.*;

public class Evangelio{
    try{
    
    String lengthInput = JOptionPane.showInputDialog("Enter the length of the rectangle: ");
    String widthInput = JOptionPane.showInputDialog("Enter the width of the rectangle: ");
    
    double length = Double.parseDouble(lengthInput);
    double width = Double.parseDouble(widthInput);
    
    double area = length * width;
    
    String Result = "Length: " + length + "\nWidth: " + width + "\nArea: " + area;
    JOptionPane.showMessageDialog(null, result, "Rectangle Area", JOptionPane.INFORMATION_MESSAGE);
    
    FileWriter writer = new FileWriter("C:\\Users\\PUP-CITE-L1PC08\\Desktop\\Evangelio");
    writer.write(result);
    writer.close();
    
    JOptionPane.showMessageDialog(null, "Result saved to Evangelio.");
    
    }catch (NumberFormatException e){
    JOption.pane.showMessageDialog(null, "Invalid Input. Please Enter NUMERIC VALUE");
}catch(IOException e){
    JOptionPane.showMessageDialog(null,"Error Writing to File);
}
}

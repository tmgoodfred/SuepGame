/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/javafx/FXMLController.java to edit this template
 */
package SuepGame;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.Label;

/**
 * FXML Controller class
 *
 * @author tylerandkatherine
 */
public class GameScreenController implements Initializable {

    @FXML
    Button nextButton = new Button();
    @FXML
    Button backButton = new Button();
    
    @FXML
    Label leviTxt = new Label();
    @FXML
    Label suepTxt = new Label();
    
    String[] leviTalk = {"oh... who are you?", "...poop time?", "oh, I'm sorry dear."};
    String[] suepTalk = {"I'm SuepTime!", "What? No! SUEP TIME"};
    
    int buttonPressCount = 0;
    
    @FXML
    void nextClicked(ActionEvent event) throws IOException {
        leviTxt.setText(leviTalk[buttonPressCount]);
        buttonPressCount += 1;
    }
    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        
    }    
    
}

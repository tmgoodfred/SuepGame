package tylerproductions.suepgame;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.Label;

public class SuepGameController {
    @FXML
    Button nextButton = new Button();
    @FXML
    Button backButton = new Button();

    @FXML
    Label leviTxt = new Label();
    @FXML
    Label suepTxt = new Label();

    String[] leviTalk = {"Oh... Who are you?","", "...Poop Time?", "", "Oh, I'm sorry dear.","Did you know...","That I love you?","",""};
    String[] suepTalk = {"", "I'm SuepTime!", "", "What? No! SUEP TIME", "","","","YOU DO?","That's kinda cringe bro."};

    int buttonPressCount = 0;

    @FXML
    void nextClicked(ActionEvent event) throws IOException {
        try {
            leviTxt.setText(leviTalk[buttonPressCount]);
            suepTxt.setText(suepTalk[buttonPressCount]);
            if(buttonPressCount <= 9) {
                buttonPressCount += 1;
            }
            else{
                System.out.println("Nope");
            }
        }
        catch(ArrayIndexOutOfBoundsException ex)
        {
            System.out.println("oops");
        }
    }
    @FXML
    void backClicked(ActionEvent event) throws IOException {
        try {
            if(buttonPressCount > 0) {
                buttonPressCount -= 1;
            }
            else{
                System.out.println("Nope");
            }
            leviTxt.setText(leviTalk[buttonPressCount]);
            suepTxt.setText(suepTalk[buttonPressCount]);
        }
        catch(ArrayIndexOutOfBoundsException ex)
        {
            System.out.println("oops");
        }
    }

    public void initialize(URL url, ResourceBundle rb) {

    }
}
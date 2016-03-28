package Factory;

import Clases.Facebook;
import Clases.Google;
import Clases.Twitter;
import Interface.InterfaceRedes;

public class FactoryRedes {

    public static InterfaceRedes getCreator(String saveItem) {

        switch (saveItem) {
            case "Facebook":
                return new Facebook();
            case "Twitter":
                return new Twitter();
            case "Google":
                return new Google();
        }
        return null;
    }

}

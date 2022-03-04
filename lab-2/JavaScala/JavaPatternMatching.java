import ScalaPatternMatching.Email;
import ScalaPatternMatching.Notification;
import ScalaPatternMatching.SMS;
import ScalaPatternMatching.VoiceRecording;
import scala.MatchError;
import scala.StringContext;
import scala.Predef.;

public final class ScalaPatternMatching$ {
    public static ScalaPatternMatching$ MODULE$;

    static {
        new ScalaPatternMatching$();
    }

    public String showNotification(final Notification notification) {
        String var2;
        if (notification instanceof Email) {
            Email var4 = (Email)notification;
            String sender = var4.sender();
            String title = var4.title();
            var2 = (new StringContext(.MODULE$.wrapRefArray((Object[])(new String[]{"You got an email from ", " with title: ", ""})))).s(.MODULE$.genericWrapArray(new Object[]{sender, title}));
        } else if (notification instanceof SMS) {
            SMS var7 = (SMS)notification;
            String number = var7.caller();
            String message = var7.message();
            var2 = (new StringContext(.MODULE$.wrapRefArray((Object[])(new String[]{"You got an SMS from ", "! Message: ", ""})))).s(.MODULE$.genericWrapArray(new Object[]{number, message}));
        } else {
            if (!(notification instanceof VoiceRecording)) {
                throw new MatchError(notification);
            }

            VoiceRecording var10 = (VoiceRecording)notification;
            String name = var10.contactName();
            String link = var10.link();
            var2 = (new StringContext(.MODULE$.wrapRefArray((Object[])(new String[]{"You received a Voice Recording from ", "! Click the link to hear it: ", ""})))).s(.MODULE$.genericWrapArray(new Object[]{name, link}));
        }

        return var2;
    }

    private ScalaPatternMatching$() {
        MODULE$ = this;
    }
}

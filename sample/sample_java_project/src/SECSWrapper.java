import kr.co.aim.scomenabler.callback.SECSListener;
import kr.co.aim.scomenabler.global.AdditionalEventObject;
import kr.co.aim.scomenabler.global.ReturnObject;
import kr.co.aim.scomenabler.plugin.SinglePlugIn;
import kr.co.aim.scomenabler.structure.SECSTransaction;
import kr.co.aim.scomenabler.timeout.SECSTimeout;

public class SECSWrapper implements SECSListener{
//	private Logger logger = Logger.getLogger(SECSWrapper.class);
		
	int nReceivedCount = 0;
	int nSentCount = 0;

	public static void main(String[] args) {
//		PropertyConfigurator.configure("log4j.properties");
		System.out.println("done " + args[0]);
		new SECSWrapper(args[0]);
	}
	
	SECSWrapper(String arg){
		SinglePlugIn plugin = new SinglePlugIn();
		ReturnObject rtObj = plugin.initialize(arg, "ScomINI.xml");
		
		if(!rtObj.isSuccess()){
			System.out.println(rtObj.getErrorObject().getErrorDiscription());
			return;
		}
		
		Boolean isSuccessful = plugin.addSECSListener(this);
		if(!isSuccessful){
			System.out.println("addSECSListener is Failed.");
			return;
		}
		
		while(true) {
			
		}
	}

	public void onConnected(String arg0) {
		// TODO Auto-generated method stub
//		logger.debug("onConnected");
	}

	public void onDisconnected(String arg0) {
		// TODO Auto-generated method stub
//		logger.info("onDisconnected");
	}

	public void onIllegal(String arg0, SECSTransaction arg1) {
		// TODO Auto-generated method stub
		
	}

	public void onLog(String arg0, String arg1) {
		// TODO Auto-generated method stub
//		logger.info(arg1);
	}

	public void onReceived(String arg0, SECSTransaction arg1) {
		// TODO Auto-generated method stub
//		logger.debug("onReceived");
	}

	public void onSECSAdditional(String arg0, AdditionalEventObject arg1) {
		// TODO Auto-generated method stub
		
	}

	public void onSendComplete(String arg0, SECSTransaction arg1) {
		// TODO Auto-generated method stub
		
	}

	public void onTimeout(String arg0, SECSTimeout arg1) {
		// TODO Auto-generated method stub
		
	}

	public void onUnknownReceived(String arg0, SECSTransaction arg1) {
		// TODO Auto-generated method stub
		
	}

}

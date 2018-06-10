import java.util.*;
import java.io.*;

public class makeData{
public static void main(String[] args){
	int max = Integer.parseInt(args[0]);
	Random rand = new Random();
	int n = rand.nextInt(max) + 1;
	try{ 
		PrintWriter writer = new PrintWriter("data.txt");
		int m = n;
		manage(n,writer);
		//number of customers
		int c = rand.nextInt(max - (max/2)) + (max/2);
		customer(c,writer);
		int d = rand.nextInt(max - (max/2)) + (max/2);
		driver(d,writer);
		int t = rand.nextInt(max - (max/2)) + (max/2);
		truck(t,writer);
		n = rand.nextInt(max - (max/2)) + (max/2);
		person(n,writer);
		//number of ice cream flavours
		int i = 16; 
		iceCream(i,writer);
		//number of factories
		n = rand.nextInt(10) +1;
		factory(m,writer);
		
		order(c,writer);
		makes(n,writer);
		owns(m,n,writer);
		delivers(n,writer);
		drives(d,t,writer);
		employs(d,m,writer);
		writer.close();
	}catch(Exception ex){
		System.err.println(ex);
	}
}


static void manage(int i, PrintWriter w){
	
	String inManage = "Insert into Management(Manager_ID) VALUES";
	w.print(inManage);
	String manage = "";
	for(int a = 0; a < i; a++){
		if(a != i-1){
			manage =" ("+(a)+"),";
		}else{
			manage =" ("+(a)+");";
		}
		w.print(manage);		
	}
	w.println("");
}
static void customer(int i, PrintWriter w){
	String inCustomer = "Insert into Customer (Customer_ID)) VALUES";
	w.print(inCustomer);
	String customer = "";
	for(int a = 0; a < i; a++){
		if(a != i-1){
			customer =" ("+(a)+"),";
		}else{
			customer =" ("+(a)+");";			
		}
		w.print(customer);
	}
	w.println("");
}
static void driver(int i, PrintWriter w){
	String inDriver = "Insert into Driver(Driver_ID)) VALUES";
	w.print(inDriver);
	String driver = "";
	for(int a = 0; a < i; a++){
		if(a != i-1){
			driver =" ("+(a)+"),";
		}else{
			driver =" ("+(a)+");";
		}
		w.print(driver);
	}
	w.println("");
}
static void person(int i,PrintWriter w){

	String inPerson = "Insert into Persons(personID,Fname, Lname, Phone_number, Street_Address, City, postcode) VALUES";
	w.print(inPerson);
	String person ="";
	for(int a = 0; a < i; a++){
	if(a != i-1){
		person =" ("+(a)+","+(rString())+","+(rString())+","+(rString())+","+(rString())+","+(rString())+"," +(rString())+"),";
	}else{
		person =" ("+(a)+","+(rString())+","+(rString())+","+(rString())+","+(rString())+","+(rString())+"," +(rString())+");";
	}
		w.print(person);
	}
	w.println("");
}
static void truck(int i, PrintWriter w){
	
	Random r = new Random();
	int n=0;
	String inTruck = "Insert into Delivery truck (Truck_ID, Type, Space_for_deilvery) VALUES";
	w.print(inTruck);
	String truck= "";
	for(int a = 0; a < i; a++){
		n = r.nextInt(20 - 10) + 10;
		if(a!= i-1){
			truck =" ("+(a)+","+(rString())+","+(n)+"),";
		}else{
			truck =" ("+(a)+","+(rString())+","+(n)+");";
		}
		w.print(truck);
	}
	w.println("");
	
}
static void iceCream(int i, PrintWriter w){
	Random r = new Random();
	int n = 0;
	String[] f ={"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p"};
	String inIceCream = "Insert into Ice Cream (Ice_Cream_ID, Flavour, Amount_made) VALUES";
	w.print(inIceCream);
	String iceCream = "";
	for(int a = 0; a < i; a++){
		n = r.nextInt(16) + 0;
		if(a != i-1){
			iceCream =" ("+(a)+","+(rString())+","+(f[n])+"),";
		}else{
			iceCream =" ("+(a)+","+(rString())+","+(f[n])+");";
		}
		w.print(iceCream);
	}
	w.println("");
}
static void factory(int i, PrintWriter w){
	String location="";
	Random r = new Random();
	int n = 0;
	
	String inFactory = "Insert into Factory(Factory_ID, Location, Amount_of_workers) VALUES";
	w.print(inFactory);
	String factory = "";
	for(int a = 0; a < i; a++){
		n = r.nextInt(8) + 1;
		if(a != i-1){
			factory =" ("+(a)+","+(location)+","+(n)+"),";
		}else{
			factory =" ("+(a)+","+(location)+","+(n)+");";
		}
		w.print(factory);
	}
	w.println("");
}
static void order(int i, PrintWriter w){
	//random date and times
	Random r = new Random();
	
	String inFactory = "Insert into Order (Date_Ordered, Time_ordered ,Ice_Cream_ID, Customer_ID) VALUES";
	w.print(inFactory);	
	String factory = "";
	int x =0;
	int d =0;
	int m = 0;
	int y = 0;
	int hr = 0;
	int min = 0;
	String date ="";
	String time = "";
	for(int a = 0; a < i; a++){
		if(x >= 17)x = 0;
		d = r.nextInt(31) +1;
		m = r.nextInt(12)+1;
		y = 2018;
	
		hr = r.nextInt(24) + 1;
		min = r.nextInt(60)+1;
	
		date= (d+"/"+m+"/"+y);
		time=(hr + ":" + min);
		if(a != i-1){
			factory =" ("+(date)+","+(time)+","+(x)+","+(a)+"),";
		}else{
			factory =" ("+(date)+","+(time)+","+(x)+","+(a)+");";
		}
		w.print(factory);
		x++;
	}
	w.println("");
}
static void makes(int i , PrintWriter w){
	int iceId=0;
	
	String make = "Insert into Makes (Factory_ID, Ice_Cream _ID) VALUES";
	w.print(make);
	String output = "";
	for(int a = 0; a < i; a++){
	if(iceId > 16) iceId = 0;
	if(a != i-1){
		output =" ("+(a)+","+(iceId)+"),";
	}else{
		output =" ("+(a)+","+(iceId)+");";
	}
		w.print(output);
		iceId ++;
	}
	w.println("");
}
// f = number of factories
static void owns(int i ,int f, PrintWriter w){
	int x =0;
	String make = "Insert into Owns (Manager_ID, Factory_ID) VALUES";
	w.print(make);
	String output = "";
	for(int a = 0; a < i; a++){
	if (x >= f) x = 0;
	if(a != i-1){
		output =" ("+(a)+","+(x)+"),";
	}else{
		output =" ("+(a)+","+(x)+");";
	}
		w.print(output);
		x++;
	}
	w.println("");
}
static void delivers(int i , PrintWriter w){
	int iceId=0;
	
	String deliver = "Insert into Delivers (Ice_cream_ID, Truck_ID) VALUES";
	w.print(deliver);
	String output = "";
	for(int a = 0; a < i; a++){
	if(iceId > 16)iceId = 0;
	if(a != i-1){
		output =" ("+(iceId)+","+(a)+"),";
	}else{
		output =" ("+(iceId)+","+(a)+");";
	}
		w.print(output);
		iceId ++;
	}
	w.println("");
}
//driver, truck, writer
static void drives(int i ,int t, PrintWriter w){
	int x = 0;	
	String drive = "Insert into Drives (Truck_ID, Driver_ID) VALUES";
	w.print(drive);
	String output = "";
	for(int a = 0; a < i; a++){
	if(x > t) x = 0;
	if(a != i-1){
		output =" ("+(x)+","+(a)+"),";
	}else{
		output =" ("+(x)+","+(a)+");";
	}
		w.print(output);
		x++;
	}
	w.println("");
}
//driver, manager, writer
static void employs(int i, int d, PrintWriter w){
	int x = 0;
	
	String employ = "Insert into Employs (Manager_ID,Driver_ID) VALUES";
	w.print(employ);
	String output = "";
	for(int a = 0; a < i; a++){
	if (x > d)x= 0;
	if(a != i-1){
		output =" ("+(x)+","+(a)+"),";
	}else{
		output =" ("+(x)+","+(a)+");";
	}
		w.print(output);
		x++;
	}
	w.println("");
}

//Produces a random string of random length between 10 and 5 
static String rString(){
	String result = "";
	char output = 'a';
	Random rand = new Random();
	int x = rand.nextInt(10 - 5) + 5;
	int n = 0;
	for(int i=0; i < x; i++){
		//random ascii value;
		n = rand.nextInt(122-97) + 97;
		output=(char)n;
		result += output;
	}
	return result;
}


}

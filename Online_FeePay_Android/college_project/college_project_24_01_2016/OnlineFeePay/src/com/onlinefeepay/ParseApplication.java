package com.onlinefeepay;

import com.parse.Parse;
import com.parse.ParseACL;
import com.parse.ParseUser;
import android.app.Application;
 
public class ParseApplication extends Application {
 
    @Override
    public void onCreate() {
        super.onCreate();
 
        // Add your initialization code here
        Parse.initialize(this, "e7l4w1SqgytVzkDmFZrd12nt72mBRSCSbJml2N6B", "3Xr21nHBc8Pj4rEhuPGKgeNOdaJh5Azkr1JLezB0");
 
        ParseUser.enableAutomaticUser();
        ParseACL defaultACL = new ParseACL();
 
        // If you would like all objects to be private by default, remove this
        // line.
        defaultACL.setPublicReadAccess(true);
 
        ParseACL.setDefaultACL(defaultACL, true);
    }
 
}
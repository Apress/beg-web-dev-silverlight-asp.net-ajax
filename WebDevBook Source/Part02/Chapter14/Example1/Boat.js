// JScript File

Type.registerNamespace("Vehicles");

Vehicles.TaxClass = function(){};
Vehicles.TaxClass.prototype = 
{
    cc100cc: 1,
    cc200cc: 2,
    cc300cc: 4,
    cc400cc: 10
}
Vehicles.TaxClass.registerClass("Vehicles.TaxClass");

Vehicles.Boat = function(boatType, boatSize, boatName) 
{
    this._boatType = boatType;
    this._boatSize = boatSize;
    this._boatName = boatName;
}

Vehicles.Boat.prototype = 
{
    getBoatType: function()
    {
        return(this._boatType);
    },
    getBoatSize: function()
    {
        return(this._boatSize);
    },
    getBoatName: function()
    {
        return(this._boatName);
    },
    getBoatDetails: function()
    {
        var strDetails = this._boatName + " is a " 
                       + this._boatType + " boat that is size: " 
                       + this._boatSize;
        return(strDetails);                       
    },
    dispose: function()
    {
        alert("destroying " + this.getBoatName());
    }
}
Vehicles.Boat.registerClass('Vehicles.Boat');

Vehicles.IPowered = function() {}
Vehicles.IPowered.Prototype = {
    checkFuel: function(){}
}
Vehicles.IPowered.registerInterface('Vehicles.IPowered');

Vehicles.SpeedBoat = function(boatSize, boatType, boatName, engineType)
{
    Vehicles.SpeedBoat.initializeBase(this,[boatSize, boatType, boatName]);
    this._engineType = engineType; 
    this._currentSpeed = 0;
}
Vehicles.SpeedBoat.prototype = {
    checkFuel: function(){
        return "Yes, I use and need fuel, because I implement IPowered";
      },
    getEngineType: function(){
        return this._engineType;
      },
    setEngineType: function(){
        this._engineType = engineType;
      },     
    checkEngine: function(){
        if (this._currentSpeed>0)
            return ("Engine is running at speed" + this._currentSpeed);
        else
            return "Engine is off";
    },
    startEngine: function(){
        if(this._currentSpeed == 0)
            this._currentSpeed = 1;
        else
            return "Engine is already running";
    },
    openThrottle: function(){
        if (this._currentSpeed<10)
            this._currentSpeed++;
    },  
    closeThrottle: function(){
        if (this._currentSpeed>0)
            this._currentSpeed--;
    }
    
}
Vehicles.SpeedBoat.registerClass('Vehicles.SpeedBoat', Vehicles.Boat, Vehicles.IPowered);



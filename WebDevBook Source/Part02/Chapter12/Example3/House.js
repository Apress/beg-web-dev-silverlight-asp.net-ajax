Type.registerNamespace("WebNext");

WebNext.House = function(streetName, townName, zipCode) {
    this._streetName = streetName;
    this._townName = townName;
    this._zipCode = zipCode;
}

WebNext.House.prototype = {

    getStreetName: function() {
        return this._streetName;
    },

    getTownName: function() {
        return this._townName;
    },

    getAddress: function() {
        return this._streetName + ' ' + this._townName + ' ' + this._zipCode;
    },

    dispose: function() {
        alert('removed ' + this.getAddress());
    }
}
WebNext.House.registerClass('WebNext.House', null, Sys.IDisposable);
if (typeof(Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();



//Check the date format for input control
function checkDate(field) { var allowBlank = true; 
    var minYear = 1902; 
    var maxYear = 2099; var errorMsg = ""; 
    // regular expression to match required date format 
    re = /^(\d{1,2})\/(\d{1,2})\/(\d{4})$/; if (field.value != '')
    { if (regs = field.value.match(re)) { if (regs[2] < 1 || regs[2] > 31) { errorMsg = "error"; } else if (regs[1] < 1 || regs[1] > 12) { errorMsg = "error"; } else if (regs[3] < minYear || regs[3] > maxYear) { errorMsg = "error"; } } else { errorMsg = "error"; } } else if (!allowBlank) { errorMsg = "error"; } if (errorMsg != "") { return false; } return true;
}


//Check the email for input control
function checkEmail(field) {   
    var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;    
    if (!filter.test(field.value)) {
        return false;
    }
    else
        return true;
}



// JScript File

function disableselect(e) {
    return false
}

function reEnable() {
    return true
}
// Code for Copy, Selecting Text in Browser
document.onselectstart = new Function("return false");
//if NS6
if (window.sidebar) {
    document.onmousedown = disableselect
    document.onclick = reEnable
}
//Function for Disable Back in Browser
function noBack() {
    window.history.forward()
}
noBack();
window.onload = noBack;
window.onpageshow = function (evt) {
    if (evt.persisted) noBack()
}
window.onunload = function () {
    void (0)
}
function rightclick() {
    if (event.button == 2) {
        alert("Right Click Disabled");
    }
}

document.onmousedown = rightclick
document.oncontextmenu = function () { return false; };


/*This Function allow only Character */
function ALLOWNUMANDSLASH(eventobj, txtObj, objcid) {
    var EnterCode; EnterCode = eventobj.which ? eventobj.which : eventobj.keyCode;
    if (EnterCode == 13) {
        objcid.focus(); //PRESS  ENTER IT FOCUS T0 NEXT CONTORL
        return;
    }
    if (EnterCode >= 48 && EnterCode <= 57 || EnterCode == 47) {
        return true;
    }
    else {
        return false;
    }
}

/* This function allow number character space slash underscore and dot */

function ALLOWNUMCHARDOTSLASHSPACEANDHASH(eventobj, previousObj, txtObj, objcid) {
    var objcid1 = document.getElementById(objcid);
    var EnterCode; EnterCode = eventobj.which ? eventobj.which : eventobj.keyCode;

    if (previousObj != null && previousObj != '') {

        if ((previousObj.value == "" || previousObj.selectedIndex == 0) && txtObj.value == "") {
            previousObj.focus();
            return false;
        }
    }
    if (EnterCode == 13) {
        objcid1.focus(); //PRESS  ENTER IT FOCUS T0 NEXT CONTORL
        return;

    }

    if (EnterCode == 64) {

        return false;
    }


    if ((EnterCode >= 65 && EnterCode <= 90) || (EnterCode >= 48 && EnterCode <= 57) || EnterCode == 32
|| EnterCode == 35)//
    {
        return true;
    }
    else {
        if (EnterCode >= 97 && EnterCode <= 122) {
            return true;
        }
        else {
            return false;
        }
    }


}
/*This Function allow only Number Character */
function ALLOWNUMBER(eventobj, previousObj, txtObj, objcid) {
    var objcid1 = document.getElementById(objcid);
    var EnterCode; EnterCode = eventobj.which ? eventobj.which : eventobj.keyCode;
    if (previousObj != null && previousObj != '') {
        if ((previousObj.value == "" || previousObj.selectedIndex == 0) && txtObj.value == "") {
            previousObj.focus();
            return false;
        }
    }
    if (EnterCode == 13) {
        objcid1.focus(); //PRESS  ENTER IT FOCUS T0 NEXT CONTORL
        return;
    }
    if (EnterCode >= 48 && EnterCode <= 57) {
        return true;
    }
    else {
        return false;
    }
}


/*This Function allow only Character */
function ALLOWNUMANDSLASH(eventobj, txtObj, objcid) {
    var EnterCode; EnterCode = eventobj.which ? eventobj.which : eventobj.keyCode;
    if (EnterCode == 13) {
        objcid.focus(); //PRESS  ENTER IT FOCUS T0 NEXT CONTORL
        return;
    }
    if (EnterCode >= 48 && EnterCode <= 57 || EnterCode == 47) {
        return true;
    }
    else {
        return false;
    }
}


//Checking UserName Values(A-Z,a-z,0-9,Backspace)
function THIS_FCheckUserNameCharacter(e) {
    var key; key = e.which ? e.which : e.keyCode;
    if ((key >= 97 && key <= 122) || (key >= 65 && key <= 90) || (key >= 48 && key <= 57) || key == 46 || key == 64 || key == 45 || key == 13) {
        e.returnValue = true;
    }
    else {
        e.returnValue = false;
    }
}
//Checking Password Values(A-Z,a-z,0-9,!@#$%&*()_+/><:",Backspace)
function THIS_FCheckPasswordCharacter(e, txtobj) {
    var key; key = e.which ? e.which : e.keyCode;
    if ((key >= 97 && key <= 122) || (key >= 65 && key <= 90) || (key >= 33 && key <= 64) || key == 46 || key == 95 || key == 13 || key == 189 || key == 16) {
        e.returnValue = true;
    }
    else {
        e.returnValue = false;
    }
}


/*This Function allow only Character */
function THIS_FALLOWNUMANDSLASH(eventobj, txtObj, objcid) {
    var EnterCode; EnterCode = eventobj.which ? eventobj.which : eventobj.keyCode;
    if (EnterCode == 13) {
        objcid.focus(); //PTHISS  ENTER IT FOCUS T0 NEXT CONTORL
        return;
    }
    if (EnterCode >= 48 && EnterCode <= 57 || EnterCode == 47) {
        return true;
    }
    else {
        return false;
    }
}

/* This Function Allow Number And Character Only*/
function THIS_FALLOWNUMANDCHAR(eventobj, previousObj, txtObj, objcid) {
    var objcid1 = document.getElementById(objcid);
    var EnterCode; EnterCode = eventobj.which ? eventobj.which : eventobj.keyCode;

    if (previousObj != null && previousObj != '') {
        if ((previousObj.value == "" || previousObj.selectedIndex == 0) && txtObj.value == "") {
            previousObj.focus();
            return false;
        }
    }
    if (EnterCode == 13) {
        objcid1.focus(); //PTHISS  ENTER IT FOCUS T0 NEXT CONTORL
        return;
    }

    if (EnterCode == 64) {

        return false;
    }


    if ((EnterCode >= 65 && EnterCode <= 90) || (EnterCode >= 48 && EnterCode <= 57))//|| EnterCode==32 
    {
        return true;
    }
    else {
        if (EnterCode >= 97 && EnterCode <= 122) {
            return true;
        }
        else {
            return false;
        }
    }

}

/* This Function Allow Number,Character and Space Only*/
function THIS_FALLOWNUMANDCHARSPACE(eventobj, previousObj, txtObj, objcid) {

    var EnterCode; EnterCode = eventobj.which ? eventobj.which : eventobj.keyCode;
    var objcid1 = document.getElementById(objcid);
    if (previousObj != null && previousObj != '') {
        if ((previousObj.value == "" || previousObj.selectedIndex == 0) && txtObj.value == "") {
            previousObj.focus();
            return false;
        }
    }
    if (EnterCode == 13) {
        objcid1.focus(); //PTHISS  ENTER IT FOCUS T0 NEXT CONTORL
        return;
    }

    if (EnterCode == 64) {

        return false;
    }

    if ((EnterCode >= 65 && EnterCode <= 90) || (EnterCode >= 48 && EnterCode <= 57) || EnterCode == 32)//
    {
        return true;
    }
    else {
        if (EnterCode >= 97 && EnterCode <= 122) {
            return true;
        }
        else {
            return false;
        }
    }

}
/* This Function Allow Number,Character and Space and Slash Only*/
function THIS_FALLOWNUMANDCHARANDSPACEANDSLASH(eventobj, previousObj, txtObj, objcid) {

    var EnterCode; EnterCode = eventobj.which ? eventobj.which : eventobj.keyCode;
    //var objcid1 = document.getElementById(objcid);
    if (previousObj != null && previousObj != '') {
        if ((previousObj.value == "" || previousObj.selectedIndex == 0) && txtObj.value == "") {
            previousObj.focus();
            return false;
        }
    }
    if (EnterCode == 13) {
        //objcid1.focus(); //PTHISS  ENTER IT FOCUS T0 NEXT CONTORL
        return;
    }

    if (EnterCode == 64) {

        return false;
    }

    if ((EnterCode >= 65 && EnterCode <= 90) || (EnterCode >= 47 && EnterCode <= 57) || EnterCode == 32)//
    {
        return true;
    }
    else {
        if (EnterCode >= 97 && EnterCode <= 122) {
            return true;
        }
        else {
            return false;
        }
    }

}

function THIS_FSETFOCUS(eventobj, objfocus) {
    var EnterCode; EnterCode = eventobj.which ? eventobj.which : eventobj.keyCode;
    //var objfocus1=document.getElementById(objfocus);
    if (EnterCode == 13) {
        objfocus.focus(); //PTHISS  ENTER IT FOCUS T0 NEXT CONTORL
        return;
    }

}

/*This Function allow only Character */
function THIS_FALLOWCHAR(eventobj, previousObj, txtObj, objcid) {
    //alert(txtObj.value.indexOf((txtObj.value.length)));
    var objcid1 = document.getElementById(objcid);
    var EnterCode; EnterCode = eventobj.which ? eventobj.which : eventobj.keyCode;

    if (previousObj != null && previousObj != '') {
        if (previousObj.value == "" && txtObj.value == "") {
            previousObj.focus();
            return false;
        }
    }

    if (EnterCode == 13) {
        objcid1.focus(); //PTHISS  ENTER IT FOCUS T0 NEXT CONTORL
        return;
    }

    if (EnterCode == 64) {
        return false;
    }


    if ((EnterCode >= 65 && EnterCode <= 90) || EnterCode == 32) {

        return true;
    }
    else {
        if (EnterCode >= 97 && EnterCode <= 122) {
            return true;
        }
        else {
            return false;
        }
    }

}
/* This function allow user to enter desimal value*/
/*only One . will allowed after . it accept 2 digits */
function THIS_FOnlydecimal(eventobj, previousObj, txtObj, objcid) {
    var EnterCode; EnterCode = eventobj.which ? eventobj.which : eventobj.keyCode;
    var objcid1 = document.getElementById(objcid);
    if (previousObj != null && previousObj != '') {
        if (previousObj.value == "" && txtObj.value == "") {
            previousObj.focus();
            return false;
        }
    }
    if (EnterCode == 13) {
        objcid1.focus(); //PTHISS  ENTER IT FOCUS T0 NEXT CONTORL
        return;
    }

    if (EnterCode == 64) {
        return false;
    }


    if (txtObj.value.charAt(txtObj.value.length) == '') {
        if (EnterCode == 32) {
            return false;
        }
    }


    if (EnterCode >= 48 && EnterCode <= 57 || EnterCode == 46) {
        if (EnterCode == 46) {
            if (txtObj.value.indexOf('.') == -1) {
                if (txtObj.value == "")
                    txtObj.value = '0';
                return true;
            }
            else {
                return false;
            }
        }


        var str = txtObj.value.split(".");

        if (str.length == 2) {
            if (str[1].length >= 2) {
                return false;
            }
        }
    }
    else {
        return false;
    }
}

function THIS_ALLOWNUMERIC(eventobj, txtObj, objcid) {
    var EnterCode; EnterCode = eventobj.which ? eventobj.which : eventobj.keyCode;
    if (EnterCode == 13) {
        objcid.focus(); //PRESS  ENTER IT FOCUS T0 NEXT CONTORL
        return;
    }
    if (EnterCode >= 48 && EnterCode <= 57) {
        return true;
    }
    else {
        return false;
    }
    return true;
}

function FALLOWNUM(eventobj, objcid) {
    var EnterCode; EnterCode = eventobj.which ? eventobj.which : eventobj.keyCode;
    var objcid1 = document.getElementById(objcid);
    if (EnterCode == 13) {
        objcid1.focus(); //PTHISS  ENTER IT FOCUS T0 NEXT CONTORL
        return;
    }
    if (EnterCode >= 49 && EnterCode <= 57 || EnterCode == 48) {
        return true;
    }
    else {
        return false;
    }
}

/*Date Format Validation Check Date Format MM/DD/YYYY*/
/*USER SHOULD ENTER MM/DD/YYYY ,IT CHECK DATE IS ENTER DATE IS VALID*/
/*DISPLAY MSG IN STATUSBAR*/

function THIS_FCHECKDATEFORMAT(strinput) {
    var validformat = /^\d{2}\/\d{2}\/\d{4}$/ //Basic check for format validity
    var returnval = false
    if (!validformat.test(strinput.value))
        window.status = 'Invalid Date Format. Please correct and submit again.';
    else {
        //check for valid date ranges
        var monthfield = strinput.value.split("/")[1]
        var dayfield = strinput.value.split("/")[0]
        var yearfield = strinput.value.split("/")[2]
        var dayobj = new Date(yearfield, monthfield - 1, dayfield)
        if ((dayobj.getMonth() + 1 != monthfield) || (dayobj.getDate() != dayfield) || (dayobj.getFullYear() != yearfield))
            window.status = 'Invalid Day, Month, or Year range detected. Please correct and submit again.';
        else
            returnval = true
    }
    if (returnval == false) strinput.select()
    return returnval
}
/* Function For Disable Mouse Handler in grid */
function THIS_FGRIDmouseOutHandler(evt) {
    if (typeof evt != 'undefined') {
        evt = window.event;
    }
    window.status = '';
    if (evt && typeof evt.returnValue != 'undefined') {
        evt.returnValue = true;
    }
    if (evt && evt.preventDefault) {
        evt.preventDefault();
    }
    return true;

}

//-----------------------------------------------------------------------------
// Author   : Sudipta Das
// Date     : 18-Nov-2008
// Purpose  : This script is to show a pop-up image.
//-----------------------------------------------------------------------------
function Large(obj) {
    var imgbox = document.getElementById("imgbox");
    imgbox.style.visibility = 'visible';
    var img = document.createElement("img");
    img.src = obj.src;
    img.style.width = '200px';
    img.style.height = '200px';

    if (img.addEventListener) {
        img.addEventListener('mouseout', Out, false);
    } else {
        img.attachEvent('onmouseout', Out);
    }
    imgbox.innerHTML = '';
    imgbox.appendChild(img);
    imgbox.style.left = (getElementLeft(obj)) + 'px';
    imgbox.style.top = (getElementTop(obj)) + 'px';
}

function Out() {
    document.getElementById("imgbox").style.visibility = 'hidden';
}

function getElementLeft(elm) {
    var x = 0;

    //set x to elm’s offsetLeft
    x = elm.offsetLeft;

    //set elm to its offsetParent
    elm = elm.offsetParent;

    //use while loop to check if elm is null
    // if not then add current elm’s offsetLeft to x
    //offsetTop to y and set elm to its offsetParent

    while (elm != null) {
        x = parseInt(x) + parseInt(elm.offsetLeft);
        elm = elm.offsetParent;
    }

    return x;
}

function getElementTop(elm) {
    var y = 0;

    //set x to elm’s offsetLeft
    y = elm.offsetTop;

    //set elm to its offsetParent
    elm = elm.offsetParent;

    //use while loop to check if elm is null
    // if not then add current elm’s offsetLeft to x
    //offsetTop to y and set elm to its offsetParent

    while (elm != null) {
        y = parseInt(y) + parseInt(elm.offsetTop);
        elm = elm.offsetParent;
    }

    return y;
}

/* -- Capture date from calendar popup window -- */


         
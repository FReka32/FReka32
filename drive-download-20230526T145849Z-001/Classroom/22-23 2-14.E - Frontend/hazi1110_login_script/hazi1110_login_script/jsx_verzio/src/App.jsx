import React from 'react';
import ReactDOM from 'react-dom';
ReactDOM.render(React.createElement(App), document.getElementById("app-container"));
function App() {
  return <form>
      <InputComponent InputId={"login"} LabelText={"Login"} InputType={"login"}></InputComponent>
      <InputComponent InputId={"pwd"} LabelText={"Pwd"} InputType={"password"}></InputComponent>
      <ButtonComponent></ButtonComponent>
      </form>
     
}
function InputComponent({InputId, LabelText, InputType}) {
    return <div class="mb-3 row">
    <label for={InputId} class="col-sm-2 form-label">{LabelText}</label>
    <div class="col-sm-10">
      <input type={InputType} readonly class="form-control" id={InputId}/>
    </div>
  </div>
}
function ButtonComponent() {
    return  <div className="mb-3 row">
                <div class="col-sm-2"></div>
                <div class="col-sm-10">
                    <button className="btn btn-primary font-weight-bold text-uppercase" type="button" onClick={() =>{
                         var logininput = document.getElementById("login");
                         var pwdinput = document.getElementById("pwd");
                         var loginval = logininput.value;
                         var pwdval = pwdinput.value;
                         if(loginval === "abc"){
                           logininput.style.backgroundColor = "#baf7ba";
                         } else if(loginval === "") {
                           logininput.style.backgroundColor = "unset";
                         } else {
                           logininput.style.backgroundColor = "#f19c9c";
                         }
                         if(pwdval === "123"){
                           pwdinput.style.backgroundColor = "#baf7ba";
                         }else if(pwdval === "") {
                           pwdinput.style.backgroundColor = "unset";
                         } else {
                           pwdinput.style.backgroundColor = "#f19c9c";
                         }
                    }}>
                    Küldés
                </button></div>
            </div>
}
export default App;
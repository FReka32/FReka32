import React from 'react';
import ReactDOM from 'react-dom';
ReactDOM.render(React.createElement(App), document.getElementById("root"));
function App() {
  return React.createElement(
    "form",
    {
        className: "border p-5",
    },
    React.createElement(LoginInputComponent, {}),
    React.createElement(PasswordInputComponent, {}),
    React.createElement(ButtonComponent, {})
  );
}
function LoginInputComponent(){
  return React.createElement(
    "div", {
      className:"mb-3 row"
    },
    React.createElement(
      "label", {
        for:"login",
        className:"form-label col-2"
      },
      "Login: "
    ),
    React.createElement(
      "div", {
        className: "col-10"
      }, 
      React.createElement(
      "input", {
        type:"text", 
        id:"login",
        className:"form-control"
      }
    )
    )
  )
}
function PasswordInputComponent(){
  return React.createElement(
    "div", {
      className:"mb-3 row"
    },
    React.createElement(
      "label", {
        for:"pwd",
        className:"form-label col-2"
      },
      "Pwd: "
    ),
    React.createElement(
      "div", {
        className: "col-10"
      }, 
      React.createElement(
      "input", {
        type:"password", 
        id:"pwd",
        className:"form-control"
      }
    )
    )
  )
}

function ButtonComponent() {
  return React.createElement(
    "div", {
      className:"mb-3 row"
    },
    React.createElement(
      "div", {
        className:"col-2"
      }
    ),
    React.createElement(
      "div", {
        className: "col-10"
      }, 
      React.createElement(
        "button",
        {
          className: "btn btn-primary font-weight-bold text-uppercase",
          type: "button",
          onClick: () => {
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
          }
        },
        "Küldés"
      )
    )
  )
}  


export default App;
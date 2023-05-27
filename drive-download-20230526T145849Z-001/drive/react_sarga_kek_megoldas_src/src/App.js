// Komponensek és propok
import React from 'react';
import ReactDOM from 'react-dom';
ReactDOM.render(React.createElement(App), document.getElementById("root"));
function App() {
  const[isActive, setActive] = React.useState(true);
  const[bgColor, setbgColor] = React.useState("green");
  return React.createElement(
    "div",
    {
        className: "border",
    },
    "App",
    React.createElement(BoxComponent, {isActive: isActive, bgColor: bgColor}),
    React.createElement(ButtonComponent, {isActive: isActive, setActive: setActive, activeColor: "green", inactiveColor: "firebrick",  setbgColor: setbgColor}),
    React.createElement(ButtonComponent, {isActive: isActive, setActive: setActive, activeColor: "yellow", inactiveColor: "blue", setbgColor: setbgColor}),
    "App szintű state: " + (isActive ? "Aktív" : "Inaktív")
  );
}
function ButtonComponent({isActive, setActive, activeColor, inactiveColor, setbgColor}) {
  return React.createElement("div", {
      style: {
        width: "200px",
        height: "200px"
      },
      className: "p-2 m-5 border rounded"
  },
  React.createElement(
    "button",
    {
      style: {
        backgroundColor: activeColor,
        color: "orange"
      },
      className: "btn m-2 font-weight-bold text-uppercase",
      disabled: isActive,
      onClick: () => {
        setActive(true);
        setbgColor(activeColor);
      }
    },
    "Aktiválás"
  ),
  React.createElement(
    "button",
    {
      style: {
        backgroundColor: inactiveColor,
        color: "orange"
      },
      className: "btn m-2 font-weight-bold text-uppercase",
      disabled: !isActive,
      onClick: () => {
        setActive(false);
        setbgColor(inactiveColor);
      }
    },
    "Deaktiválás"
  )
  );
}  

function BoxComponent(props) {
  return React.createElement(
    "div",
    {
      style: {
        width: "200px",
        height: "200px",
        backgroundColor: props.bgColor,
        color: "orange",
        fontWeight: "700"
      },
      className: "p-2 m-5 border rounded",
    },

    props.isActive ? "AKTÍV": "INAKTÍV"
  );
}



export default App;
// Komponensek és propok
import React from 'react';
import ReactDOM from 'react-dom';
function App() {
  return React.createElement(
    "div",
    {
      className: "border",
    },
    "App",
    //A korábban elkészített feladathoz képest készítsetek 5 dobozt, lehet méretileg ugyanakkora, számok legyenek rajta, és különböző színűek legyenek!
    React.createElement(BoxComponent, { hatterSzin: "rgb(255,0,51)", felirat: "1." }),
    React.createElement(BoxComponent, { hatterSzin: "rgb(224,0,92)", felirat: "2." }),
    React.createElement(BoxComponent, { hatterSzin: "rgb(194,0,133)", felirat: "3." }),
    React.createElement(BoxComponent, { hatterSzin: "rgb(163,0,173)", felirat: "4." }),
    React.createElement(BoxComponent, { hatterSzin: "rgb(102,0,255)", felirat: "5." }),
  );
}

function BoxComponent(props) {
  return React.createElement(
    "div",
    {
      style: {
        width: "200px",
        height: "200px",
        backgroundColor: props.hatterSzin,
        color: "white"
      },
      className: "p-2 m-5 rounded",
    },
    props.felirat
  );
}

ReactDOM.render(React.createElement(App), document.getElementById("root"));
export default App;
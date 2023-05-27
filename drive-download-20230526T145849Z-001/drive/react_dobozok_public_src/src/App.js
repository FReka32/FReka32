// Komponensek és propok
import React from 'react';
import ReactDOM from 'react-dom';
ReactDOM.render(React.createElement(App), document.getElementById("root"));
  function App() {
    return React.createElement(
      "div",
      {
        className: "border",
      },
      "App",
      //A korábban elkészített feladathoz képest készítsetek 5 dobozt, lehet méretileg ugyanakkora, számok legyenek rajta, és különböző színűek legyenek!
      React.createElement(BoxComponent, { hatterSzin: "rgb(255,0,51)", kezdetiSzamlalo: 1 }),
      React.createElement(BoxComponent, { hatterSzin: "rgb(224,0,92)", kezdetiSzamlalo: 2 }),
      React.createElement(BoxComponent, { hatterSzin: "rgb(194,0,133)", kezdetiSzamlalo: 3 }),
      React.createElement(BoxComponent, { hatterSzin: "rgb(163,0,173)", kezdetiSzamlalo: 4 }),
      React.createElement(BoxComponent, { hatterSzin: "rgb(102,0,255)", kezdetiSzamlalo: 5 }),
    );
  }
  
  function BoxComponent(props) {
    const [szamlaloAllapota, ujSzamlaloAllapotBeallitasa] = React.useState(props.kezdetiSzamlalo);
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
        onClick: () => {
          ujSzamlaloAllapotBeallitasa(elozoAllapot => elozoAllapot + 1)
        }
      },
      React.createElement("h1", {}, szamlaloAllapota)
    );
  }
  


export default App;
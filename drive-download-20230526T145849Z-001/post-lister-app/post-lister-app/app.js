var _slicedToArray = function () { function sliceIterator(arr, i) { var _arr = []; var _n = true; var _d = false; var _e = undefined; try { for (var _i = arr[Symbol.iterator](), _s; !(_n = (_s = _i.next()).done); _n = true) { _arr.push(_s.value); if (i && _arr.length === i) break; } } catch (err) { _d = true; _e = err; } finally { try { if (!_n && _i["return"]) _i["return"](); } finally { if (_d) throw _e; } } return _arr; } return function (arr, i) { if (Array.isArray(arr)) { return arr; } else if (Symbol.iterator in Object(arr)) { return sliceIterator(arr, i); } else { throw new TypeError("Invalid attempt to destructure non-iterable instance"); } }; }();

function App() {
  var _React$useState = React.useState([]),
      _React$useState2 = _slicedToArray(_React$useState, 2),
      items = _React$useState2[0],
      setItems = _React$useState2[1];

  React.useEffect(function () {
    fetch("https://localhost:7214/api/Gyumolcs/GetGyumolcsok").then(function (res) {
      return res.ok ? res.json() : [];
    }).then(function (tartalom) {
      setItems(tartalom);
    });
  });

  return React.createElement(
    "div",
    { className: "container" },
    React.createElement(
      "div",
      { className: "row m-5 p-5" },
      React.createElement(ListaKomponens, { elemek: items })
    )
  );
}

var ListaKomponens = function ListaKomponens(_ref) {
  var elemek = _ref.elemek;
  return React.createElement(
    "main",
    null,
    React.createElement(
      "div",
      { "class": "container m-4" },
      React.createElement(
        "div",
        { "class": "row" },
        elemek.map(function (elem) {
          return React.createElement(
            "div",
            { "class": "col-4" },
            React.createElement(
              "div",
              { className: "card" },
              React.createElement("img", { className: "card-img-top", src: elem.kepUtvonala, alt: "Card image", style: { width: "100%" } }),
              React.createElement(
                "div",
                { className: "card-body" },
                React.createElement(
                  "strong",
                  null,
                  "Term\xE9k neve:"
                ),
                " ",
                elem.nev,
                React.createElement("br", null),
                React.createElement(
                  "strong",
                  null,
                  "Term\xE9k \xE1ra:"
                ),
                " ",
                elem.ar,
                React.createElement("br", null),
                React.createElement(
                  "strong",
                  null,
                  "Term\xE9k oszt\xE1lya:"
                ),
                " ",
                elem.minoseg,
                ". oszt\xE1ly\xFA"
              )
            )
          );
        })
      )
    )
  );
};

ReactDOM.render(React.createElement(App), document.getElementById("app-container"));
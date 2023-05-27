function App() {
 const [items, setItems] = React.useState([]);

 React.useEffect(() => {
   fetch("https://localhost:7214/api/Gyumolcs/GetGyumolcsok")
     .then((res) => (res.ok ? res.json() : []))
     .then((tartalom) => {
       setItems(tartalom)
     });
 }, );

 return (
   <div className="container">
     <div className="row m-5 p-5">
       <ListaKomponens elemek={items} />
     </div>
   </div>
 );
}

const ListaKomponens = ({ elemek }) => (
<main>
  <div class="container m-4">
    <div class="row">
    {elemek.map((elem) => (
        <div class="col-4">
          <div className="card">
            <img className="card-img-top" src={elem.kepUtvonala} alt="Card image" style={{width:"100%"}}/>
            <div className="card-body">
              <strong>Termék neve:</strong> {elem.nev}<br/>
              <strong>Termék ára:</strong> {elem.ar}<br/>
              <strong>Termék osztálya:</strong> {elem.minoseg}. osztályú
            </div>
          </div>
        </div>  
    ))}
    </div>
  </div>
</main>
);

ReactDOM.render(React.createElement(App), document.getElementById("app-container"));

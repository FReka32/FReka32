import { BrowserRouter as Router, NavLink, Routes, Route } from "react-router-dom";
import { ProductListPage } from "./ProductListPage";
import { ProductSinglePage } from "./ProductSinglePage";
import { ProductCreatePage } from "./ProductCreatePage";
import { ProductModPage } from "./ProductModPage";
import './App.css';

function App() {
  return (
    <Router>
      <nav className="navbar navbar-expand-sm navbar-dark bg-dark">
        <div className="collapse navbar-collapse" id="navbarNav">
          <ul className="navbar-nav">
            <li className="nav-item">
              <NavLink to={'/'} className={({isActive}) => "nav-link" + (isActive ? "active" : "")}>
                <span className="nav-link">Termékek</span>
              </NavLink>
              </li>
              <li className="nav-item">
              <NavLink to={'/uj-product'} className={({isActive}) => "nav-link" + (isActive ? "active" : "")}>
                <span className="nav-link">Új termék</span>
              </NavLink>
              </li>
          </ul>
        </div>
      </nav>
      <Routes>
        <Route path="/" exact element={<ProductListPage />} />
        <Route path="/product/:productId" exact element={<ProductSinglePage />} />
        <Route path="/uj-product" exact element={<ProductCreatePage />} />
        <Route path="/mod-product/:productId" exact element={<ProductModPage />} />
      </Routes>
    </Router>
  );
}

export default App;
import React, { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';

export function ProductModPage(props) {
    const params = useParams();
    const id = params.productId;
    const navigate = useNavigate();
    const [product,setProduct] = useState([]);
    const[modname,setModname] = useState('');
    const[modprice,setModprice] = useState('');
    const[modqty,setModqty] = useState('');
    const[modflagimg,setModflagimg] = useState('');
    const[modsales,setModsales] = useState('');

    useEffect(() => {
        (async () => {

            try {
                const res = await fetch(`https://localhost:5001/Product/${id}`)
                const product = await res.json();
                setProduct(product);
                setModname(product.Name);
                console.log(modname);
                setModprice(product.Price);
                console.log(modprice);
                setModqty(product.Qty);
                console.log(modqty);
                setModflagimg(product.Flagimg);
                console.log(modflagimg);
                setModsales(product.Sales);
                console.log(modsales);
            }
            catch(error) {
                console.log(error);
            }
        })
        (); //dependency listában minden olyan változót meg kell adni, amitől függ az oldal render-elése:
    }, [id,modname,modprice,modqty,modflagimg,modsales]);
   
    const modName = event => {
        setModname(event.target.value);
    }
    const modPrice = event => {
        setModprice(event.target.value);
    }
    const modQty = event => {
        setModqty(event.target.value);
    }
    const modFlagimg = event => {
        setModflagimg(event.target.value);
    }
    const modSales = event => {
        setModsales(event.target.value);
    }

    return (
        <div className="p-5 content bg-whitesmoke text-center">
            <h2>Termék módosítása</h2>
            <form
            onSubmit={(event) => {
                event.persist();
                event.preventDefault();
                fetch(`https://localhost:5001/Product/${id}`, {
                    method: "PUT",
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({
                        Name: event.target.elements.name.value,
                        Price: event.target.elements.price.value,
                        Qty: event.target.elements.qty.value,
                        Flagimg: event.target.elements.flagimg.value,
                        Sales: event.target.elements.sales.value,
                    }),
                })
                .then(() => {
                    navigate("/");
                })
                .catch(console.log);
            }}>
                <div className="form-group row pb-3">
                    <label className="col-sm-3 col-form-label">Product ID:</label>
                    <div className="col-sm-9">
                        <input type="text" name="id" className="form-control" value={product.Id}/>
                    </div>
                </div>
                <div className="form-group row pb-3">
                    <label className="col-sm-3 col-form-label">Product név:</label>
                    <div className="col-sm-9">
                        <input type="text" name="name" className="form-control" defaultValue={product.Name} onChange={modName}/>
                    </div>
                </div>
                <div className="form-group row pb-3">
                    <label className="col-sm-3 col-form-label">Ár:</label>
                    <div className="col-sm-9">
                        <input type="text" name="price" className="form-control" defaultValue={product.Price} onChange={modPrice}/>
                    </div>
                </div>
                <div className="form-group row pb-3">
                    <label className="col-sm-3 col-form-label">Mennyiség:</label>
                    <div className="col-sm-9">
                        <input type="text" name="qty" className="form-control" defaultValue={product.Qty} onChange={modQty}/>
                    </div>
                </div>
                <div className="form-group row pb-3">
                    <label className="col-sm-3 col-form-label">Kép URL:</label>
                    <div className="col-sm-9">
                        <input type="text" name="flagimg" className="form-control" defaultValue={product.Flagimg} onChange={modFlagimg}/>
                    <img src={product.Flagimg} height="200px" alt={product.name}/>
                    </div>
                </div>
                <div className="form-group row pb-3">
                    <label className="col-sm-3 col-form-label">Akció:</label>
                    <div className="col-sm-9">
                        <input type="text" name="sales" className="form-control" defaultValue={product.Sales} onChange={modSales}/>
                    </div>
                </div>
                <button type="submit" className="btn btn-success">Küldés</button>
            </form>
        </div>
    );
    }
export default ProductModPage;
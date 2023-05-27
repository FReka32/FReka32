import React, { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';

export function ZaszloModPage(props) {
    const params = useParams();
    const id = params.zaszloId;
    const navigate = useNavigate();
    const [zaszlo,setZaszlo] = useState([]);
    const[modname,setModname] = useState('');
    const[modprice,setModprice] = useState('');
    const[modqty,setModqty] = useState('');
    const[modflagimg,setModflagimg] = useState('');
    const[modsales,setModsales] = useState('');

    useEffect(() => {
        (async () => {
            try {
                const res = await fetch(`https://localhost:5001/Zaszlok/${id}`)
                const zaszlo = await res.json();
                setZaszlo(zaszlo);
                setModname(zaszlo.name);
                console.log(modname);
                setModprice(zaszlo.price);
                console.log(modprice);
                setModqty(zaszlo.qty);
                console.log(modqty);
                setModflagimg(zaszlo.flagimg);
                console.log(modflagimg);
                setModsales(zaszlo.sales);
                console.log(modsales);
            }
            catch(error) {
                console.log(error);
            }
        })
        (); //dependency listában minden olyan változót meg kell adni, amitől függ az oldal render-elése:
    }, [id,setModname,setModprice,setModqty,setModflagimg,setModsales]);
   
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
            <h2>Zászló módosítása</h2>
            <form
            onSubmit={(event) => {
                event.persist();
                event.preventDefault();
                fetch(`https://localhost:5001/Zaszlok/${id}`, {
                    method: "PUT",
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({
                        name: event.target.elements.name.value,
                        price: event.target.elements.price.value,
                        qty: event.target.elements.qty.value,
                        flagimg: event.target.elements.flagimg.value,
                        sales: event.target.elements.sales.value,
                    }),
                })
                .then(() => {
                    navigate("/");
                })
                .catch(console.log);
            }}>
                <div className="form-group row pb-3">
                    <label className="col-sm-3 col-form-label">Zászló ID:</label>
                    <div className="col-sm-9">
                        <input type="text" name="id" className="form-control" value={zaszlo.id}/>
                    </div>
                </div>
                <div className="form-group row pb-3">
                    <label className="col-sm-3 col-form-label">Zászló név:</label>
                    <div className="col-sm-9">
                        <input type="text" name="name" className="form-control" defaultValue={zaszlo.name} onChange={modName}/>
                    </div>
                </div>
                <div className="form-group row pb-3">
                    <label className="col-sm-3 col-form-label">Ár:</label>
                    <div className="col-sm-9">
                        <input type="text" name="price" className="form-control" defaultValue={zaszlo.price} onChange={modPrice}/>
                    </div>
                </div>
                <div className="form-group row pb-3">
                    <label className="col-sm-3 col-form-label">Mennyiség:</label>
                    <div className="col-sm-9">
                        <input type="text" name="qty" className="form-control" defaultValue={zaszlo.qty} onChange={modQty}/>
                    </div>
                </div>
                <div className="form-group row pb-3">
                    <label className="col-sm-3 col-form-label">Kép URL:</label>
                    <div className="col-sm-9">
                        <input type="text" name="flagimg" className="form-control" defaultValue={zaszlo.flagimg} onChange={modFlagimg}/>
                    <img src={zaszlo.flagimg} height="200px" alt={zaszlo.name}/>
                    </div>
                </div>
                <div className="form-group row pb-3">
                    <label className="col-sm-3 col-form-label">Akció:</label>
                    <div className="col-sm-9">
                        <input type="text" name="sales" className="form-control" defaultValue={zaszlo.sales} onChange={modSales}/>
                    </div>
                </div>
                <button type="submit" className="btn btn-success">Küldés</button>
            </form>
        </div>
    );
    }
export default ZaszloModPage;
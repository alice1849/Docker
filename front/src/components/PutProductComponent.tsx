import { useState } from "react";

const PutProductComponent = () => {

    const [name, setName] = useState("");
    const [price, setPrice] = useState(0);
    const [id, setId] = useState("");
    const updateProduct =  async () => {
        debugger
        const url = 'https://localhost:7123/Product/' + id;
        console.log(url);
        const response = await fetch('https://localhost:7123/Product/' + id,{
            method: 'PUT',
            body: JSON.stringify({
                "name": name,
                "price": price
            }),
            mode: 'cors',
            headers: {
                'Content-Type': 'application/json'
              },
        });
        console.log('product updated');
        
 
    }
   return (
    <div>
        <legend>Update product </legend>
        <p>
            <label >Product id</label><br />
            <input type="text" value={id} onChange={(e)=> setId(e.target.value)} />
        </p>
         <p>
            <label >New name</label><br />
            <input type="text" value={name} onChange={(e)=> setName(e.target.value)} />
        </p>
        <p>
            <label >New price</label><br />
            <input type="number" value={price} onChange={(e)=> setPrice(e.target.valueAsNumber)} />
        </p>  
       
        <button onClick={() => updateProduct()}>UPDATE</button>
                 
            
    </div>
   );
}
export default PutProductComponent
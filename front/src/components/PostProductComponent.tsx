import { useState } from "react";
import { Button, Form } from "react-bootstrap";

const PostProductComponent = () => {

    const [name, setName] = useState("");
    const [price, setPrice] = useState(0);
    const createProduct =  async () => {
        debugger
        const response = await fetch('https://localhost:7123/Product',{
            method: 'POST',
            body: JSON.stringify({
                "name": name,
                "price": price
            }),
            mode: 'cors',
            headers: {
                'Content-Type': 'application/json'
              },
        });
        console.log('product created');
        
 
    }
   return (
    <div>
        <legend>Create product </legend>
         <p>
            <label >Name</label><br />
            <input type="text" value={name} onChange={(e)=> setName(e.target.value)} />
        </p>
        <p>
            <label >Price</label><br />
            <input type="number" value={price} onChange={(e)=> setPrice(e.target.valueAsNumber)} />
        </p>  
       
        <button onClick={() => createProduct()}>CREATE</button>
            
    </div>
   );
}
export default PostProductComponent
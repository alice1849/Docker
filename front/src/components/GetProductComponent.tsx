import { useState } from "react";
import { Button, Form } from "react-bootstrap";
import { Product } from "../models/ProductModel";
import ProductComponent from './ProductComponent';
//import  { Button } from 'react-bootstrap';

const GetProductComponent = () => {

    const [productId, setId] = useState("");
    const [loadedProduct, setLoadedProduct] = useState<Product | null>(null);
    

    const getProduct  = async (): Promise<Product> => {
        //debugger
        console.log(productId);
        const url = "https://localhost:7123/Product/" + productId;
        console.log(url);
  
        const response = await fetch (url, {
          method: "GET",
          mode: 'cors'
        });
        
        const result = await response.json();
        debugger
        console.log(result);
        setLoadedProduct(result);
        return await result as Product ;
       
      
      }
      const ret = <div>
      <legend>Get product by id</legend>
      <p>
        <label>id:
            <input type='text' value={productId} onChange={(e) => setId(e.target.value)}></input>
            <button onClick={() => getProduct()}>GET</button>
        </label>
      </p>
     <ProductComponent product={loadedProduct }></ProductComponent>

</div>

      

    return(
      <>

            <label>Get product by id</label>
          <Form.Group className="mb-3" controlId="formBasicEmail">
            <Form.Label>Id</Form.Label>
            <Form.Control type="text" placeholder="Enter id" onChange={(e) => setId(e.target.value)}/>
          </Form.Group>
          <Button variant="primary" type="submit" onClick={() => getProduct()}>
            GET
          </Button>
        
        <ProductComponent product={loadedProduct }></ProductComponent>
        
        </>
    );
}
export default GetProductComponent
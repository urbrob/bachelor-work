class CreateProductInCarts < ActiveRecord::Migration[6.1]
  def change
    create_table :product_in_carts do |t|
      t.integer :amount

      t.timestamps
    end
    add_reference :product_in_carts, :user, foreign_key: true
    add_reference :product_in_carts, :products, foreign_key: true
    add_reference :product_in_carts, :shoppings, foreign_key: true
  end
end

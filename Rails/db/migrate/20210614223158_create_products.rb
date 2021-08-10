class CreateProducts < ActiveRecord::Migration[6.1]
  def change
    create_table :products do |t|
      t.string :name
      t.decimal :price

      t.timestamps
    end
    add_reference :products, :user, foreign_key: true
  end
end

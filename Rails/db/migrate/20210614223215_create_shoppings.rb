class CreateShoppings < ActiveRecord::Migration[6.1]
  def change
    create_table :shoppings do |t|
      t.date :date
      t.boolean :is_done

      t.timestamps
    end
    add_reference :shoppings, :user, foreign_key: true
  end
end

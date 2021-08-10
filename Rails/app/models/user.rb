class User < ApplicationRecord
  include Clearance::User
  has_many :shopping
  has_many :products
  has_many :product_in_carts
end

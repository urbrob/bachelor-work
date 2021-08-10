class ShoppingController < ApplicationController
  before_action :require_login
  def index
      @shoppings = current_user.shopping
  end

  def new
    @shopping = current_user.shopping.build
  end
  def destroy
    shopping = current_user.shopping.find(params[:id])
    shopping.destroy
    redirect_to shopping_path, notice: "Deleted shopping"
  end

  def create
    @shopping = current_user.shopping.build(shopping_params)
    @shopping.save
    redirect_to shopping_path(@shopping), notice: "Shopping created"
  end

  def show
    @shopping = current_user.shopping.find(params[:id])
  end

  private
  def shopping_params
    params.permit(:date)
  end
end

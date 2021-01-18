<?php include("pageHeader.php"); ?>
<?php
$pageName = "Venda Direta";
?>
<?php include("breadcrumb.php"); ?>


            <div class="row">
                <div class="col-12 mb-5">
                    <h1><?php echo $pageName ?></h1>  
                    <div>                       
                        <!--Indicadores-->
                        <!--Info-->
                        <a class="mr-lg-2" id="info" href="#">
                            <i class="fa fa-fw fa-info-circle text-dark"></i>
                            <span class="d-lg-none">Total</span>
                            <span class="badge badge-pill badge-dark">1235</span>
                        </a>
                        <a class="mr-lg-2" id="ok" href="#">
                            <i class="fa fa-fw fa-check-circle text-success"></i>
                            <span class="d-lg-none">OK</span>
                            <span class="badge badge-pill badge-success">1235</span>
                        </a>
                        <a class="mr-lg-2" id="Error" href="#">
                            <i class="fa fa-fw fa-exclamation-circle text-danger"></i>
                            <span class="d-lg-none">Com problemas</span>
                            <span class="badge badge-pill badge-danger">1235</span>
                        </a>     
                        <a class="mr-lg-5" id="New" href="#">
                            <i class="fa fa-fw fa-plus-circle text-primary"></i>
                            <span class="text-dark">Novo</span>
                        </a>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-12">
                    <!--Table-->
                    <div class="col-10 mb-5">
                        <table data-toggle="table" data-search="true" data-show-columns="true">
                            <thead>
                                <tr class="tr-class-1">
                                    <th data-field="nomeCampanha" data-valign="middle">Campanha</th>
                                    <th data-field="cliente">Cliente</th>
                                    <th data-field="produto">Produto</th>
                                    <th data-field="valor">Valor</th>
                                    <th>Ações</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr id="tr-id-1" class="tr-class-1" data-title="CompraDePontos table" data-object='{"key": "value"}'>
                                    <td id="td-id-1" class="td-class-1">Campanha 01</td>
                                    <td>Itaú</td>
                                    <td>20</td>
                                    <td>80000</td>
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>                                      
                                    </td>
                                </tr>
                                <tr id="tr-id-2" class="tr-class-2">
                                    <td id="td-id-2" class="td-class-2">Campanha 02</td>
                                    <td>Sulamerica</td>
                                    <td>10</td>
                                    <td>150000</td>
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>    
                                    </td>
                                </tr>
                                <tr id="tr-id-3" class="tr-class-3">
                                    <td id="td-id-3" class="td-class-3">Campanha 03</td>
                                    <td>Itaú</td>
                                    <td>30</td>
                                    <td>450000</td>
                                    <td>
                                       <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>    
                                    </td>
                                </tr>
                                <tr id="tr-id-4" class="tr-class-4">
                                    <td id="td-id-4" class="td-class-4">Campanha 04</td>
                                    <td>Vivo</td>
                                    <td>10</td>
                                    <td>100000</td>
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>    
                                    </td>
                                </tr>
                                <tr id="tr-id-5" class="tr-class-5">
                                    <td id="td-id-5" class="td-class-5">Campanha 05</td>
                                    <td>BB</td>
                                    <td>10</td>
                                    <td>1000</td>
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit" title="Alterar"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger" title="Excluir"></i></a>    
                                    </td>
                                </tr>

                            </tbody>
                        </table>
                    </div>
                    <!--Form-->
                    <div class="col-10 mb-5">
                        <div class="card text-white bg-dark o-hidden h-100">
                            <div class="card-header">
                                <div class="mr-5">
                                    <h4>
                                        <i class="fa fa-fw fa-shopping-basket"></i>&nbsp; <?php echo $pageName ?>
                                    </h4>
                                </div>
                            </div>
                            <form>
                                <div class="card-body bg-light text-dark">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label for="nomeCampanha">Nome</label>
                                            <input type="text" class="form-control" name="nomeCampanha" id="nomeCampanha" placeholder="Digite o nome da Campanha" />
                                        </div>                                  
                                        <div class="col-md-6">
                                            <label for="cliente">Cliente</label>
                                            <input type="text" disabled class="form-control" name="cliente" id="cliente" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label for="produto">Produto</label>
                                            <select  class="form-control" name="produto" id="produto">
                                                
                                                <option value="produto1" selected>Produto 1</option>
                                                <option value="produto2" selected>Produto 2</option>
                                                <option value="produto3" selected>Produto 3</option>
                                                <option value="" selected>Selecione ...</option>
                                            </select>
                                        </div>                                        
                                         <div class="col-md-6">
                                            <label for="tipo">tipo</label>
                                            <input type="text" disabled class="form-control" value="Voucher" name="cliente" id="cliente" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-3">
                                            <label for="codPlataforma">CódPlataforma</label>
                                            <input type="number" disabled class="form-control" name="totalPontos" id="codPlataforma" />
                                        </div>
                                        <div class="col-md-3">
                                            <label for="valor">Valor</label>
                                            <input type="number" class="form-control" name="valor" id="valor" />
                                        </div>
                                        <div class="col-md-3">
                                            <label for="quantidade">quantidade</label>
                                            <input type="number" class="form-control" name="quantidade" id="quantidade" />
                                        </div>
                                        <div class="col-md-3">
                                            <label for="valorTotal">Valor Total</label>
                                            <input type="number" disabled class="form-control" name="valorTotal" id="valorTotal" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label for="status">Status da Compra</label>
                                            <select  class="form-control" name="status" id="status">                                                
                                                <option value="pendente" selected>Pendente</option>
                                                <option value="concluida" selected>Comcluida</option>
                                                <option value="recebida" selected>Recebida</option>
                                                <option value="" selected>Selecione ...</option>
                                            </select>
                                        </div>                                        
                                         <div class="col-md-6">
                                            <label for="dataCadastro">Data Cadastro</label>
                                            <input type="text" class="form-control" value="20-10-2020" name="dataCadastro" id="dataCadastro" />
                                        </div>
                                    </div>
                                     <div class="row">
                                        <div class="col-md-12">
                                            <label for="observacao">Observação</label>
                                            <textarea class="form-control" name="observacao" id="observacao"></textarea>
                                        </div>                                        
                                    </div>
                                </div>
                                <div class="card-footer bg-dark pull-right">
                                    <button class="btn btn-success" type="submit">Salvar</button>
                                    <button class="btn btn-danger" type="reset">Cancelar</button>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>    

            </div>
        
<?php include("pageFooter.php"); ?>
